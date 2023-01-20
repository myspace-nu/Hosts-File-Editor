namespace Host_File_Editor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.hostsPanel = new System.Windows.Forms.Panel();
            this.panelAddHost = new System.Windows.Forms.Panel();
            this.buttonAddCancel = new CustomControls.RJControls.RJButton();
            this.textboxEditComment = new CustomControls.RJControls.RJTextBox();
            this.textboxEditIP = new CustomControls.RJControls.RJTextBox();
            this.buttonSaveHost = new CustomControls.RJControls.RJButton();
            this.textboxEditHostname = new CustomControls.RJControls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelEditHost = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.buttonCancelModal = new CustomControls.RJControls.RJButton();
            this.rjButton4 = new CustomControls.RJControls.RJButton();
            this.settingsHideHostnames = new CustomControls.RJControls.RJTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rjButton3 = new CustomControls.RJControls.RJButton();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.panelAddHost.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hostsPanel
            // 
            this.hostsPanel.AutoScroll = true;
            this.hostsPanel.Location = new System.Drawing.Point(12, 147);
            this.hostsPanel.Name = "hostsPanel";
            this.hostsPanel.Size = new System.Drawing.Size(846, 273);
            this.hostsPanel.TabIndex = 1;
            // 
            // panelAddHost
            // 
            this.panelAddHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panelAddHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddHost.Controls.Add(this.buttonAddCancel);
            this.panelAddHost.Controls.Add(this.textboxEditComment);
            this.panelAddHost.Controls.Add(this.textboxEditIP);
            this.panelAddHost.Controls.Add(this.buttonSaveHost);
            this.panelAddHost.Controls.Add(this.textboxEditHostname);
            this.panelAddHost.Controls.Add(this.label4);
            this.panelAddHost.Controls.Add(this.label3);
            this.panelAddHost.Controls.Add(this.label2);
            this.panelAddHost.Controls.Add(this.labelEditHost);
            this.panelAddHost.Location = new System.Drawing.Point(930, 375);
            this.panelAddHost.Name = "panelAddHost";
            this.panelAddHost.Size = new System.Drawing.Size(665, 357);
            this.panelAddHost.TabIndex = 1;
            // 
            // buttonAddCancel
            // 
            this.buttonAddCancel.BackColor = System.Drawing.Color.White;
            this.buttonAddCancel.BackgroundColor = System.Drawing.Color.White;
            this.buttonAddCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.buttonAddCancel.BorderRadius = 10;
            this.buttonAddCancel.BorderSize = 0;
            this.buttonAddCancel.FlatAppearance.BorderSize = 0;
            this.buttonAddCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.buttonAddCancel.Location = new System.Drawing.Point(267, 263);
            this.buttonAddCancel.Name = "buttonAddCancel";
            this.buttonAddCancel.Size = new System.Drawing.Size(100, 40);
            this.buttonAddCancel.TabIndex = 7;
            this.buttonAddCancel.Text = "Cancel";
            this.buttonAddCancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.buttonAddCancel.UseVisualStyleBackColor = false;
            this.buttonAddCancel.Click += new System.EventHandler(this.buttonAddCancel_Click);
            // 
            // textboxEditComment
            // 
            this.textboxEditComment.BackColor = System.Drawing.SystemColors.Window;
            this.textboxEditComment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textboxEditComment.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.textboxEditComment.BorderRadius = 5;
            this.textboxEditComment.BorderSize = 2;
            this.textboxEditComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxEditComment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.textboxEditComment.Location = new System.Drawing.Point(45, 212);
            this.textboxEditComment.Margin = new System.Windows.Forms.Padding(4);
            this.textboxEditComment.Multiline = false;
            this.textboxEditComment.Name = "textboxEditComment";
            this.textboxEditComment.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textboxEditComment.PasswordChar = false;
            this.textboxEditComment.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textboxEditComment.PlaceholderText = "";
            this.textboxEditComment.Size = new System.Drawing.Size(322, 31);
            this.textboxEditComment.TabIndex = 3;
            this.textboxEditComment.Texts = "";
            this.textboxEditComment.UnderlinedStyle = false;
            // 
            // textboxEditIP
            // 
            this.textboxEditIP.BackColor = System.Drawing.SystemColors.Window;
            this.textboxEditIP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textboxEditIP.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.textboxEditIP.BorderRadius = 5;
            this.textboxEditIP.BorderSize = 2;
            this.textboxEditIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxEditIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.textboxEditIP.Location = new System.Drawing.Point(45, 160);
            this.textboxEditIP.Margin = new System.Windows.Forms.Padding(4);
            this.textboxEditIP.Multiline = false;
            this.textboxEditIP.Name = "textboxEditIP";
            this.textboxEditIP.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textboxEditIP.PasswordChar = false;
            this.textboxEditIP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textboxEditIP.PlaceholderText = "";
            this.textboxEditIP.Size = new System.Drawing.Size(322, 31);
            this.textboxEditIP.TabIndex = 2;
            this.textboxEditIP.Texts = "";
            this.textboxEditIP.UnderlinedStyle = false;
            // 
            // buttonSaveHost
            // 
            this.buttonSaveHost.BackColor = System.Drawing.Color.White;
            this.buttonSaveHost.BackgroundColor = System.Drawing.Color.White;
            this.buttonSaveHost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.buttonSaveHost.BorderRadius = 10;
            this.buttonSaveHost.BorderSize = 0;
            this.buttonSaveHost.FlatAppearance.BorderSize = 0;
            this.buttonSaveHost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveHost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.buttonSaveHost.Location = new System.Drawing.Point(43, 263);
            this.buttonSaveHost.Name = "buttonSaveHost";
            this.buttonSaveHost.Size = new System.Drawing.Size(100, 40);
            this.buttonSaveHost.TabIndex = 4;
            this.buttonSaveHost.Text = "Save";
            this.buttonSaveHost.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.buttonSaveHost.UseVisualStyleBackColor = false;
            this.buttonSaveHost.Click += new System.EventHandler(this.buttonEditHostSave_Click);
            // 
            // textboxEditHostname
            // 
            this.textboxEditHostname.BackColor = System.Drawing.SystemColors.Window;
            this.textboxEditHostname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textboxEditHostname.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.textboxEditHostname.BorderRadius = 5;
            this.textboxEditHostname.BorderSize = 2;
            this.textboxEditHostname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxEditHostname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.textboxEditHostname.Location = new System.Drawing.Point(43, 108);
            this.textboxEditHostname.Margin = new System.Windows.Forms.Padding(4);
            this.textboxEditHostname.Multiline = false;
            this.textboxEditHostname.Name = "textboxEditHostname";
            this.textboxEditHostname.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textboxEditHostname.PasswordChar = false;
            this.textboxEditHostname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textboxEditHostname.PlaceholderText = "";
            this.textboxEditHostname.Size = new System.Drawing.Size(322, 31);
            this.textboxEditHostname.TabIndex = 1;
            this.textboxEditHostname.Texts = "";
            this.textboxEditHostname.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Comment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "IP address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hostname";
            // 
            // labelEditHost
            // 
            this.labelEditHost.AutoSize = true;
            this.labelEditHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditHost.ForeColor = System.Drawing.Color.White;
            this.labelEditHost.Location = new System.Drawing.Point(40, 28);
            this.labelEditHost.Name = "labelEditHost";
            this.labelEditHost.Size = new System.Drawing.Size(87, 25);
            this.labelEditHost.TabIndex = 3;
            this.labelEditHost.Text = "Edit host";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Host File Editor";
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.settingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingsPanel.Controls.Add(this.buttonCancelModal);
            this.settingsPanel.Controls.Add(this.rjButton4);
            this.settingsPanel.Controls.Add(this.settingsHideHostnames);
            this.settingsPanel.Controls.Add(this.label8);
            this.settingsPanel.Controls.Add(this.label9);
            this.settingsPanel.Location = new System.Drawing.Point(930, 12);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(665, 357);
            this.settingsPanel.TabIndex = 13;
            // 
            // buttonCancelModal
            // 
            this.buttonCancelModal.BackColor = System.Drawing.Color.White;
            this.buttonCancelModal.BackgroundColor = System.Drawing.Color.White;
            this.buttonCancelModal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.buttonCancelModal.BorderRadius = 10;
            this.buttonCancelModal.BorderSize = 0;
            this.buttonCancelModal.FlatAppearance.BorderSize = 0;
            this.buttonCancelModal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelModal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.buttonCancelModal.Location = new System.Drawing.Point(265, 263);
            this.buttonCancelModal.Name = "buttonCancelModal";
            this.buttonCancelModal.Size = new System.Drawing.Size(100, 40);
            this.buttonCancelModal.TabIndex = 11;
            this.buttonCancelModal.Text = "Cancel";
            this.buttonCancelModal.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.buttonCancelModal.UseVisualStyleBackColor = false;
            this.buttonCancelModal.Click += new System.EventHandler(this.buttonCancelModal_Click);
            // 
            // rjButton4
            // 
            this.rjButton4.BackColor = System.Drawing.Color.White;
            this.rjButton4.BackgroundColor = System.Drawing.Color.White;
            this.rjButton4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.rjButton4.BorderRadius = 10;
            this.rjButton4.BorderSize = 0;
            this.rjButton4.FlatAppearance.BorderSize = 0;
            this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.rjButton4.Location = new System.Drawing.Point(45, 263);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(100, 40);
            this.rjButton4.TabIndex = 10;
            this.rjButton4.Text = "Save";
            this.rjButton4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.rjButton4.UseVisualStyleBackColor = false;
            this.rjButton4.Click += new System.EventHandler(this.buttonSettingsSave_Click);
            // 
            // settingsHideHostnames
            // 
            this.settingsHideHostnames.BackColor = System.Drawing.SystemColors.Window;
            this.settingsHideHostnames.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.settingsHideHostnames.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.settingsHideHostnames.BorderRadius = 5;
            this.settingsHideHostnames.BorderSize = 2;
            this.settingsHideHostnames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsHideHostnames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.settingsHideHostnames.Location = new System.Drawing.Point(43, 108);
            this.settingsHideHostnames.Margin = new System.Windows.Forms.Padding(4);
            this.settingsHideHostnames.Multiline = false;
            this.settingsHideHostnames.Name = "settingsHideHostnames";
            this.settingsHideHostnames.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.settingsHideHostnames.PasswordChar = false;
            this.settingsHideHostnames.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.settingsHideHostnames.PlaceholderText = "";
            this.settingsHideHostnames.Size = new System.Drawing.Size(322, 31);
            this.settingsHideHostnames.TabIndex = 7;
            this.settingsHideHostnames.Texts = "";
            this.settingsHideHostnames.UnderlinedStyle = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(40, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Hide hostnames (comma separated list)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(40, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Settings";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Host_File_Editor.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 25);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.White;
            this.rjButton3.BackgroundColor = System.Drawing.Color.White;
            this.rjButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.rjButton3.BorderRadius = 10;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.rjButton3.Location = new System.Drawing.Point(758, 43);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(100, 40);
            this.rjButton3.TabIndex = 3;
            this.rjButton3.Text = "Settings";
            this.rjButton3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.settingsBtnClick);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.White;
            this.rjButton1.BackgroundColor = System.Drawing.Color.White;
            this.rjButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.rjButton1.Location = new System.Drawing.Point(12, 101);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(100, 40);
            this.rjButton1.TabIndex = 2;
            this.rjButton1.Text = "Add host";
            this.rjButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.buttonAddHost_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1573, 900);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.panelAddHost);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.hostsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Hosts File Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.panelAddHost.ResumeLayout(false);
            this.panelAddHost.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel hostsPanel;
        private System.Windows.Forms.Panel panelAddHost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelEditHost;
        private System.Windows.Forms.Label label5;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJTextBox textboxEditHostname;
        private CustomControls.RJControls.RJButton buttonSaveHost;
        private CustomControls.RJControls.RJButton rjButton3;
        private CustomControls.RJControls.RJTextBox textboxEditComment;
        private CustomControls.RJControls.RJTextBox textboxEditIP;
        private System.Windows.Forms.Panel settingsPanel;
        private CustomControls.RJControls.RJButton rjButton4;
        private CustomControls.RJControls.RJTextBox settingsHideHostnames;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private CustomControls.RJControls.RJButton buttonAddCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomControls.RJControls.RJButton buttonCancelModal;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

