namespace WACCTV
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.webcamView = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleFullscreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stretchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusDeviceName = new System.Windows.Forms.ToolStripStatusLabel();
            this.viewRecordingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webcamView)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // webcamView
            // 
            this.webcamView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.webcamView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webcamView.Location = new System.Drawing.Point(0, 24);
            this.webcamView.Name = "webcamView";
            this.webcamView.Size = new System.Drawing.Size(320, 240);
            this.webcamView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.webcamView.TabIndex = 0;
            this.webcamView.TabStop = false;
            this.webcamView.DoubleClick += new System.EventHandler(this.webcamView_DoubleClick);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.recordToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(320, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.menuItemClicked);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.toggleFullscreenToolStripMenuItem,
            this.zoomModeToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.menuItemClicked);
            // 
            // toggleFullscreenToolStripMenuItem
            // 
            this.toggleFullscreenToolStripMenuItem.Name = "toggleFullscreenToolStripMenuItem";
            this.toggleFullscreenToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.toggleFullscreenToolStripMenuItem.Text = "Toggle Fullscreen";
            this.toggleFullscreenToolStripMenuItem.Click += new System.EventHandler(this.menuItemClicked);
            // 
            // zoomModeToolStripMenuItem
            // 
            this.zoomModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fitToolStripMenuItem,
            this.stretchToolStripMenuItem});
            this.zoomModeToolStripMenuItem.Name = "zoomModeToolStripMenuItem";
            this.zoomModeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.zoomModeToolStripMenuItem.Text = "Zoom Mode";
            // 
            // fitToolStripMenuItem
            // 
            this.fitToolStripMenuItem.Name = "fitToolStripMenuItem";
            this.fitToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.fitToolStripMenuItem.Text = "Fit";
            this.fitToolStripMenuItem.Click += new System.EventHandler(this.menuItemClicked);
            // 
            // stretchToolStripMenuItem
            // 
            this.stretchToolStripMenuItem.Name = "stretchToolStripMenuItem";
            this.stretchToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.stretchToolStripMenuItem.Text = "Stretch";
            this.stretchToolStripMenuItem.Click += new System.EventHandler(this.menuItemClicked);
            // 
            // recordToolStripMenuItem
            // 
            this.recordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            this.recordToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.recordToolStripMenuItem.Text = "Record";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.menuItemClicked);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Enabled = false;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.menuItemClicked);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.menuItemClicked);
            // 
            // statusStrip
            // 
            this.statusStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusInfo,
            this.statusStripTime,
            this.statusStripInfo,
            this.statusDeviceName});
            this.statusStrip.Location = new System.Drawing.Point(0, 242);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(320, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusInfo
            // 
            this.statusInfo.BackColor = System.Drawing.Color.Transparent;
            this.statusInfo.Name = "statusInfo";
            this.statusInfo.Size = new System.Drawing.Size(50, 17);
            this.statusInfo.Text = "Standby";
            // 
            // statusStripTime
            // 
            this.statusStripTime.BackColor = System.Drawing.Color.Transparent;
            this.statusStripTime.Name = "statusStripTime";
            this.statusStripTime.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStripInfo
            // 
            this.statusStripInfo.BackColor = System.Drawing.Color.Transparent;
            this.statusStripInfo.Name = "statusStripInfo";
            this.statusStripInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // statusDeviceName
            // 
            this.statusDeviceName.BackColor = System.Drawing.Color.Transparent;
            this.statusDeviceName.Name = "statusDeviceName";
            this.statusDeviceName.Size = new System.Drawing.Size(255, 17);
            this.statusDeviceName.Spring = true;
            this.statusDeviceName.Text = "Unknown Device";
            this.statusDeviceName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // viewRecordingLabel
            // 
            this.viewRecordingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.viewRecordingLabel.AutoSize = true;
            this.viewRecordingLabel.BackColor = System.Drawing.Color.Transparent;
            this.viewRecordingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewRecordingLabel.ForeColor = System.Drawing.Color.White;
            this.viewRecordingLabel.Location = new System.Drawing.Point(181, 196);
            this.viewRecordingLabel.Margin = new System.Windows.Forms.Padding(0);
            this.viewRecordingLabel.Name = "viewRecordingLabel";
            this.viewRecordingLabel.Padding = new System.Windows.Forms.Padding(5);
            this.viewRecordingLabel.Size = new System.Drawing.Size(130, 36);
            this.viewRecordingLabel.TabIndex = 3;
            this.viewRecordingLabel.Text = "Recording";
            this.viewRecordingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewRecordingLabel.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(320, 264);
            this.Controls.Add(this.viewRecordingLabel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.webcamView);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WACCTV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_Closing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webcamView)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox webcamView;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusInfo;
        private System.Windows.Forms.ToolStripStatusLabel statusStripTime;
        private System.Windows.Forms.ToolStripStatusLabel statusStripInfo;
        private System.Windows.Forms.ToolStripStatusLabel statusDeviceName;
        private System.Windows.Forms.ToolStripMenuItem toggleFullscreenToolStripMenuItem;
        private System.Windows.Forms.Label viewRecordingLabel;
        private System.Windows.Forms.ToolStripMenuItem zoomModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stretchToolStripMenuItem;
    }
}

