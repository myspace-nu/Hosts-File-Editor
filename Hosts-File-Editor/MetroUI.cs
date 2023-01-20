using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Host_File_Editor
{
    class MetroUI
    {
        public static Color colorAccent = Color.FromArgb(255, 0, 174, 219);
        public static Color colorBackground = Color.FromArgb(255, 17, 17, 17);
        public static Color colorButtonBackground = Color.FromArgb(255, 255, 255, 255);
        public static Color colorButtonHover = Color.FromArgb(255, 238, 238, 238);


        private static Form MetroForm;
        private static Panel MetroModalPanel;
        private static PictureBox MetroModalOverlay = new PictureBox();
        public static void Initialize(Form metroForm)
        {
            MetroForm = metroForm;
            metroForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            metroForm.BackColor = colorBackground;

            PictureBox titleLine = new PictureBox();
            titleLine.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
            titleLine.Location = new Point(0, 0);
            titleLine.Size = new Size(metroForm.ClientSize.Width, 5);
            titleLine.BackColor = MetroUI.colorAccent;
            metroForm.Controls.Add(titleLine);

            MetroControls.MetroButton titleClose = new MetroControls.MetroButton();
            titleClose.Size = new Size(25, 25);
            titleClose.Location = new Point(metroForm.ClientSize.Width - 30, 5);
            titleClose.FlatStyle = FlatStyle.Flat;
            titleClose.FlatAppearance.BorderSize = 0;
            titleClose.Font = new Font("Webdings", 11, FontStyle.Regular, new GraphicsUnit(), 2);
            titleClose.Padding = new Padding(0);
            titleClose.BackColor = colorButtonBackground;
            titleClose.FlatAppearance.MouseOverBackColor = colorButtonHover;
            titleClose.FlatAppearance.MouseDownBackColor = colorAccent;
            titleClose.Text = "r";
            titleClose.Click += new EventHandler(closeApplication);
            metroForm.Controls.Add(titleClose);

            MetroControls.MetroButton titleMinimize = new MetroControls.MetroButton();
            titleMinimize.Size = new Size(25, 25);
            titleMinimize.Location = new Point(metroForm.ClientSize.Width - 55, 5);
            titleMinimize.FlatStyle = FlatStyle.Flat;
            titleMinimize.FlatAppearance.BorderSize = 0;
            titleMinimize.Font = new Font("Webdings", 11, FontStyle.Regular, new GraphicsUnit(), 2);
            titleMinimize.Padding = new Padding(0);
            titleMinimize.BackColor = colorButtonBackground;
            titleMinimize.FlatAppearance.MouseOverBackColor = colorButtonHover;
            titleMinimize.FlatAppearance.MouseDownBackColor = colorAccent;
            titleMinimize.Text = "0";
            titleMinimize.Click += new EventHandler(minimize);
            metroForm.Controls.Add(titleMinimize);

        }
        public static void modalPanel(Panel pnl)
        {
            MetroModalPanel = pnl;
            MetroModalPanel.Visible = true;
            Bitmap bmp = TakeSnapshot();
            bmp = darken(bmp);
            MetroForm.Controls.Add(MetroModalOverlay);
            MetroModalOverlay.Image = bmp;
            MetroModalOverlay.Dock = DockStyle.Fill;
            MetroModalOverlay.BringToFront();
            pnl.Location = new Point(10, 40);
            pnl.Size = new Size(MetroForm.ClientSize.Width - 20, MetroForm.ClientSize.Height - 50);
            pnl.BringToFront();
        }
        public static void closeModalPanel()
        {
            MetroForm.Controls.Remove(MetroModalOverlay);
            MetroModalPanel.Visible = false;

        }
        public static void styleControl(CustomControls.RJControls.RJButton btn)
        {
            btn.BackColor = colorButtonBackground;
            btn.FlatAppearance.MouseOverBackColor = colorButtonHover;
            btn.FlatAppearance.MouseDownBackColor = colorAccent;
            btn.ForeColor = colorBackground;
            btn.BorderRadius = 5;
        }

        public static Bitmap TakeSnapshot()
        {
            Bitmap bmp = new Bitmap(MetroForm.Size.Width, MetroForm.Size.Height);
            using (Graphics g = System.Drawing.Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(
                    MetroForm.PointToScreen(MetroForm.ClientRectangle.Location),
                    new Point(0, 0), MetroForm.ClientRectangle.Size
                );
            }
            return bmp;
        }
        public static Bitmap darken(Bitmap bmp)
        {
            Rectangle r = new Rectangle(0, 0, bmp.Width, bmp.Height);
            int alpha = 200;
            using (Graphics g = Graphics.FromImage(bmp))
            {
                using (Brush cloud_brush = new SolidBrush(Color.FromArgb(alpha, Color.Black)))
                {
                    g.FillRectangle(cloud_brush, r);
                }
            }
            return bmp;
        }
        private static void closeApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private static void minimize(object sender, EventArgs e)
        {
            MetroForm.WindowState = FormWindowState.Minimized;
        }


        public class MetroControls
        {
            public class MetroButton : Button
            {
                private string ownerDrawText;
                public string OwnerDrawText
                {
                    get { return ownerDrawText; }
                    set { ownerDrawText = value; Invalidate(); }
                }

                protected override void OnPaint(PaintEventArgs e)
                {
                    base.OnPaint(e);

                    if (string.IsNullOrEmpty(Text) && !string.IsNullOrEmpty(ownerDrawText))
                    {
                        StringFormat stringFormat = new StringFormat();
                        stringFormat.Alignment = StringAlignment.Center;
                        stringFormat.LineAlignment = StringAlignment.Center;

                        e.Graphics.DrawString(ownerDrawText, Font, new SolidBrush(ForeColor), ClientRectangle, stringFormat);
                    }
                }
            }

        }
    }
}


