using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hosts_File_Editor
{
    public partial class MainForm : Form
    {
        private Hostsfile hostfile;
        private ToolTip toolTip = new ToolTip();
        private Configuration configManager;

        // Enable drag window
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Set up notify icon
            notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // notifyIcon.BalloonTipText = "[Balloon Text when Minimized]";
            // notifyIcon.BalloonTipTitle = "[Balloon Title when Minimized]";
            notifyIcon.Icon = Properties.Resources.dns;
            notifyIcon.Text = "Double-click to open";
            notifyIcon.Visible = false;

            // Set up tooltip
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 500;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;

            // Set up config file
            configManager = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Set up main form
            this.Size = new Size(hostsPanel.Left * 2 + hostsPanel.Width + 20, hostsPanel.Top + hostsPanel.Height + hostsPanel.Left + 40);
            MetroUI.Initialize(this);
            updateHostPanel();
        }

        // Main dialog events
        private void settingsBtnClick(object sender, EventArgs e)
        {
            settingsHideHostnames.Texts = ConfigurationManager.AppSettings["hideHosts"];
            settingsHideHostnames.Focus();
            MetroUI.modalPanel(settingsPanel);
        }
        private void toggleEntry(object sender, System.EventArgs evt)
        {
            CustomControls.RJControls.RJToggleButton toggle = (CustomControls.RJControls.RJToggleButton)sender;
            int i = 0;
            Int32.TryParse(toggle.Parent.Tag.ToString(), out i);
            hostfile.Hosts[i].Active = toggle.Checked;
            hostfile.writeToFile();
        }
        private void editEntry(object sender, System.EventArgs evt)
        {
            CustomControls.RJControls.RJButton btn = (CustomControls.RJControls.RJButton)sender;
            int i = -1;
            Int32.TryParse(btn.Parent.Tag.ToString(), out i);
            labelEditHost.Text = "Edit host";
            textboxEditHostname.Texts = hostfile.Hosts[i].Hostname;
            textboxEditIP.Texts = hostfile.Hosts[i].IP;
            textboxEditComment.Texts = hostfile.Hosts[i].Comment;
            panelAddHost.Tag = i.ToString();
            MetroUI.modalPanel(panelAddHost);
            textboxEditHostname.Focus();
        }
        private void deleteEntry(object sender, System.EventArgs evt)
        {
            CustomControls.RJControls.RJButton btn = (CustomControls.RJControls.RJButton)sender;
            int i = -1;
            Int32.TryParse(btn.Parent.Tag.ToString(), out i);
            if (MessageBox.Show("Are you sure you want to remove the hostname " + hostfile.Hosts[i].Hostname + "?", "Remove hostname", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                hostfile.Hosts.RemoveAt(i);
                hostfile.writeToFile();
                updateHostPanel();
            }
        }
        private void buttonAddHost_Click(object sender, EventArgs e)
        {
            labelEditHost.Text = "Add host";
            panelAddHost.Tag = "";
            MetroUI.modalPanel(panelAddHost);
            textboxEditHostname.Focus();
        }

        // Settings dialog events
        private void buttonSettingsSave_Click(object sender, EventArgs e)
        {
            configManager.AppSettings.Settings.Remove("hideHosts");
            configManager.AppSettings.Settings.Add("hideHosts", settingsHideHostnames.Texts);
            configManager.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configManager.AppSettings.SectionInformation.Name);
            updateHostPanel();
            MetroUI.closeModalPanel();
        }
        private void buttonAddCancel_Click(object sender, EventArgs e)
        {
            textboxEditHostname.Texts = textboxEditIP.Texts = textboxEditComment.Texts = "";
            MetroUI.closeModalPanel();
        }

        // Host edit dialog events
        private void buttonEditHostSave_Click(object sender, EventArgs e)
        {
            int i = -1;
            Int32.TryParse(panelAddHost.Tag.ToString(), out i);
            if (!string.IsNullOrEmpty(panelAddHost.Tag.ToString()) && i >= 0)
            {
                hostfile.Hosts[i].Hostname = textboxEditHostname.Texts;
                hostfile.Hosts[i].IP = textboxEditIP.Texts;
                hostfile.Hosts[i].Comment = textboxEditComment.Texts;
            }
            else {
                hostfile.Hosts.Add(new Host(textboxEditHostname.Texts, textboxEditIP.Texts, textboxEditComment.Texts, true));

            }
            hostfile.writeToFile();
            updateHostPanel();
            MetroUI.closeModalPanel();
        }


        // Helper functions
        private void updateHostPanel()
        {
            hostfile = new Hostsfile().fromFile(); // @"%USERPROFILE%\Desktop\hosts.txt"
            for (int i = hostsPanel.Controls.Count - 1; i >= 0; i--)
            {
                hostsPanel.Controls.RemoveAt(i);
            }
            int iShown = 0;
            System.Text.RegularExpressions.Regex regsplit = new System.Text.RegularExpressions.Regex("[\\s\\,]+");
            string[] hideHosts = regsplit.Split(string.IsNullOrEmpty(ConfigurationManager.AppSettings["hideHosts"]) ? "" : ConfigurationManager.AppSettings["hideHosts"]);
            for (var i = 0; i < hostfile.Hosts.Count; i++)
            {
                bool hide = false;
                foreach(string hideHost in hideHosts)
                {
                    if (!string.IsNullOrEmpty(hideHost) && hostfile.Hosts[i].Hostname.Contains(hideHost)) { hide = true; }
                }
                if (hide) { continue; } else { iShown++; }

                Panel pnl = new Panel();
                pnl.Tag = i.ToString();
                pnl.Size = new Size(hostsPanel.Width - 20, 45);
                pnl.Location = new Point(0, 10 + ((iShown-1) * 50));
                pnl.BorderStyle = BorderStyle.FixedSingle;

                Label ipLabel = new Label();
                ipLabel.Size = new Size(120, 30);
                ipLabel.Location = new Point(10, 10);
                ipLabel.Font = new Font("Microsoft Sans Serif", 11);
                ipLabel.ForeColor = Color.Gray;
                ipLabel.Text = hostfile.Hosts[i].IP;

                Label hostNameLabel = new Label();
                hostNameLabel.Size = new Size(230, 30);
                hostNameLabel.Location = new Point(130, 10);
                hostNameLabel.Font = new Font("Microsoft Sans Serif", 11);
                hostNameLabel.ForeColor = Color.Gray;
                hostNameLabel.Text = hostfile.Hosts[i].Hostname;
                toolTip.SetToolTip(hostNameLabel, hostfile.Hosts[i].Hostname);

                Label commentLabel = new Label();
                commentLabel.Size = new Size(200, 30);
                commentLabel.Location = new Point(360, 10);
                commentLabel.Font = new Font("Microsoft Sans Serif", 11);
                commentLabel.ForeColor = Color.Gray;
                commentLabel.Text = hostfile.Hosts[i].Comment;
                toolTip.SetToolTip(hostNameLabel, hostfile.Hosts[i].Comment);


                CustomControls.RJControls.RJToggleButton chkbox = new CustomControls.RJControls.RJToggleButton();
                chkbox.Size = new Size(30, 15);
                chkbox.OnBackColor = MetroUI.colorAccent;
                chkbox.Location = new Point(pnl.Width - 60, 10);
                chkbox.Checked = hostfile.Hosts[i].Active;
                chkbox.CheckedChanged += new EventHandler(toggleEntry);

                CustomControls.RJControls.RJButton deletebtn = new CustomControls.RJControls.RJButton();
                deletebtn.Size = new Size(25, 25);
                deletebtn.Location = new Point(pnl.Width - 90, 10);
                deletebtn.Image = Hosts_File_Editor.Properties.Resources.delete;
                MetroUI.styleControl(deletebtn);
                deletebtn.BackColor = MetroUI.colorBackground;
                deletebtn.FlatAppearance.MouseOverBackColor = MetroUI.colorBackground;
                deletebtn.Click += new EventHandler(deleteEntry);

                CustomControls.RJControls.RJButton editbtn = new CustomControls.RJControls.RJButton();
                editbtn.Size = new Size(25, 25);
                editbtn.Location = new Point(pnl.Width - 120, 10);
                editbtn.Image = Hosts_File_Editor.Properties.Resources.edit;
                MetroUI.styleControl(editbtn);
                editbtn.BackColor = MetroUI.colorBackground;
                editbtn.FlatAppearance.MouseOverBackColor = MetroUI.colorBackground;
                editbtn.Click += new EventHandler(editEntry);


                pnl.Controls.Add(hostNameLabel);
                pnl.Controls.Add(ipLabel);
                pnl.Controls.Add(commentLabel);
                pnl.Controls.Add(chkbox);
                pnl.Controls.Add(deletebtn);
                pnl.Controls.Add(editbtn);

                hostsPanel.Controls.Add(pnl);
            }
        }
        private void buttonCancelModal_Click(object sender, EventArgs e)
        {
            MetroUI.closeModalPanel();
        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon.Visible = true;
                if(!string.IsNullOrEmpty(notifyIcon.BalloonTipText) && !string.IsNullOrEmpty(notifyIcon.BalloonTipTitle))
                {
                    notifyIcon.ShowBalloonTip(3000);
                }
                this.ShowInTaskbar = false;
            }
        }
        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }
        private static bool IsAdministrator()
        {
            return (new System.Security.Principal.WindowsPrincipal(System.Security.Principal.WindowsIdentity.GetCurrent()))
                      .IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator);
        }
        private static bool RunAsAdministrator()
        {
            if (!IsAdministrator())
            {
                System.Diagnostics.ProcessStartInfo proc = new System.Diagnostics.ProcessStartInfo();
                proc.UseShellExecute = true;
                proc.WorkingDirectory = Environment.CurrentDirectory;
                proc.FileName = Application.ExecutablePath;
                proc.Verb = "runas";
                try
                {
                    System.Diagnostics.Process.Start(proc);
                    Application.Exit();
                }
                catch
                {
                    // The user refused the elevation.
                    return false;
                }
            }
            return true;
        }
    }
}
