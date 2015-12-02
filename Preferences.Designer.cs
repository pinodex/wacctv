namespace WACCTV
{
    partial class Preferences
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
            this.cameraDeviceLabel = new System.Windows.Forms.Label();
            this.cameraDevicesCombo = new System.Windows.Forms.ComboBox();
            this.resolutionLabel = new System.Windows.Forms.Label();
            this.cameraResolutionCombo = new System.Windows.Forms.ComboBox();
            this.recordingFrameRateLabel = new System.Windows.Forms.Label();
            this.targetDirectoryLabel = new System.Windows.Forms.Label();
            this.targetDirectoryField = new System.Windows.Forms.TextBox();
            this.folderBrowseButton = new System.Windows.Forms.Button();
            this.preferencesSaveButton = new System.Windows.Forms.Button();
            this.recordingFrameRate = new System.Windows.Forms.NumericUpDown();
            this.cameraGroupBox = new System.Windows.Forms.GroupBox();
            this.recordingGroupBox = new System.Windows.Forms.GroupBox();
            this.webGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listeningInterfacesField = new System.Windows.Forms.TextBox();
            this.authenticationGroupBox = new System.Windows.Forms.GroupBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.enableWebServerCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.recordingFrameRate)).BeginInit();
            this.cameraGroupBox.SuspendLayout();
            this.recordingGroupBox.SuspendLayout();
            this.webGroupBox.SuspendLayout();
            this.authenticationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cameraDeviceLabel
            // 
            this.cameraDeviceLabel.AutoSize = true;
            this.cameraDeviceLabel.Location = new System.Drawing.Point(6, 16);
            this.cameraDeviceLabel.Name = "cameraDeviceLabel";
            this.cameraDeviceLabel.Size = new System.Drawing.Size(41, 13);
            this.cameraDeviceLabel.TabIndex = 1;
            this.cameraDeviceLabel.Text = "Device";
            // 
            // cameraDevicesCombo
            // 
            this.cameraDevicesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cameraDevicesCombo.FormattingEnabled = true;
            this.cameraDevicesCombo.Location = new System.Drawing.Point(6, 32);
            this.cameraDevicesCombo.Name = "cameraDevicesCombo";
            this.cameraDevicesCombo.Size = new System.Drawing.Size(348, 21);
            this.cameraDevicesCombo.TabIndex = 1;
            this.cameraDevicesCombo.SelectedValueChanged += new System.EventHandler(this.cameraDevicesCombo_SelectedValueChanged);
            // 
            // resolutionLabel
            // 
            this.resolutionLabel.AutoSize = true;
            this.resolutionLabel.Location = new System.Drawing.Point(6, 57);
            this.resolutionLabel.Name = "resolutionLabel";
            this.resolutionLabel.Size = new System.Drawing.Size(57, 13);
            this.resolutionLabel.TabIndex = 1;
            this.resolutionLabel.Text = "Resolution";
            // 
            // cameraResolutionCombo
            // 
            this.cameraResolutionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cameraResolutionCombo.FormattingEnabled = true;
            this.cameraResolutionCombo.Location = new System.Drawing.Point(6, 73);
            this.cameraResolutionCombo.Name = "cameraResolutionCombo";
            this.cameraResolutionCombo.Size = new System.Drawing.Size(348, 21);
            this.cameraResolutionCombo.TabIndex = 3;
            // 
            // recordingFrameRateLabel
            // 
            this.recordingFrameRateLabel.AutoSize = true;
            this.recordingFrameRateLabel.Location = new System.Drawing.Point(6, 16);
            this.recordingFrameRateLabel.Name = "recordingFrameRateLabel";
            this.recordingFrameRateLabel.Size = new System.Drawing.Size(62, 13);
            this.recordingFrameRateLabel.TabIndex = 1;
            this.recordingFrameRateLabel.Text = "Frame Rate";
            // 
            // targetDirectoryLabel
            // 
            this.targetDirectoryLabel.AutoSize = true;
            this.targetDirectoryLabel.Location = new System.Drawing.Point(74, 16);
            this.targetDirectoryLabel.Name = "targetDirectoryLabel";
            this.targetDirectoryLabel.Size = new System.Drawing.Size(83, 13);
            this.targetDirectoryLabel.TabIndex = 1;
            this.targetDirectoryLabel.Text = "Target Directory";
            // 
            // targetDirectoryField
            // 
            this.targetDirectoryField.Location = new System.Drawing.Point(74, 31);
            this.targetDirectoryField.Name = "targetDirectoryField";
            this.targetDirectoryField.Size = new System.Drawing.Size(199, 20);
            this.targetDirectoryField.TabIndex = 1;
            // 
            // folderBrowseButton
            // 
            this.folderBrowseButton.Location = new System.Drawing.Point(279, 29);
            this.folderBrowseButton.Name = "folderBrowseButton";
            this.folderBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.folderBrowseButton.TabIndex = 1;
            this.folderBrowseButton.Text = "Browse";
            this.folderBrowseButton.UseVisualStyleBackColor = true;
            this.folderBrowseButton.Click += new System.EventHandler(this.folderBrowseButton_Click);
            // 
            // preferencesSaveButton
            // 
            this.preferencesSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.preferencesSaveButton.Location = new System.Drawing.Point(297, 398);
            this.preferencesSaveButton.Name = "preferencesSaveButton";
            this.preferencesSaveButton.Size = new System.Drawing.Size(75, 23);
            this.preferencesSaveButton.TabIndex = 9;
            this.preferencesSaveButton.Text = "Save";
            this.preferencesSaveButton.UseVisualStyleBackColor = true;
            this.preferencesSaveButton.Click += new System.EventHandler(this.preferencesSaveButton_Click);
            // 
            // recordingFrameRate
            // 
            this.recordingFrameRate.Location = new System.Drawing.Point(6, 32);
            this.recordingFrameRate.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.recordingFrameRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.recordingFrameRate.Name = "recordingFrameRate";
            this.recordingFrameRate.Size = new System.Drawing.Size(59, 20);
            this.recordingFrameRate.TabIndex = 1;
            this.recordingFrameRate.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // cameraGroupBox
            // 
            this.cameraGroupBox.Controls.Add(this.cameraDeviceLabel);
            this.cameraGroupBox.Controls.Add(this.cameraDevicesCombo);
            this.cameraGroupBox.Controls.Add(this.resolutionLabel);
            this.cameraGroupBox.Controls.Add(this.cameraResolutionCombo);
            this.cameraGroupBox.Location = new System.Drawing.Point(12, 12);
            this.cameraGroupBox.Name = "cameraGroupBox";
            this.cameraGroupBox.Size = new System.Drawing.Size(360, 105);
            this.cameraGroupBox.TabIndex = 0;
            this.cameraGroupBox.TabStop = false;
            this.cameraGroupBox.Text = "Camera";
            // 
            // recordingGroupBox
            // 
            this.recordingGroupBox.Controls.Add(this.targetDirectoryLabel);
            this.recordingGroupBox.Controls.Add(this.recordingFrameRate);
            this.recordingGroupBox.Controls.Add(this.targetDirectoryField);
            this.recordingGroupBox.Controls.Add(this.folderBrowseButton);
            this.recordingGroupBox.Controls.Add(this.recordingFrameRateLabel);
            this.recordingGroupBox.Location = new System.Drawing.Point(12, 123);
            this.recordingGroupBox.Name = "recordingGroupBox";
            this.recordingGroupBox.Size = new System.Drawing.Size(360, 61);
            this.recordingGroupBox.TabIndex = 0;
            this.recordingGroupBox.TabStop = false;
            this.recordingGroupBox.Text = "Recording";
            // 
            // webGroupBox
            // 
            this.webGroupBox.Controls.Add(this.enableWebServerCheckbox);
            this.webGroupBox.Controls.Add(this.authenticationGroupBox);
            this.webGroupBox.Controls.Add(this.listeningInterfacesField);
            this.webGroupBox.Controls.Add(this.label1);
            this.webGroupBox.Location = new System.Drawing.Point(12, 190);
            this.webGroupBox.Name = "webGroupBox";
            this.webGroupBox.Size = new System.Drawing.Size(360, 202);
            this.webGroupBox.TabIndex = 0;
            this.webGroupBox.TabStop = false;
            this.webGroupBox.Text = "Web";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listening Interfaces (one per line, change requires application restart)";
            // 
            // listeningInterfacesField
            // 
            this.listeningInterfacesField.Location = new System.Drawing.Point(6, 67);
            this.listeningInterfacesField.Multiline = true;
            this.listeningInterfacesField.Name = "listeningInterfacesField";
            this.listeningInterfacesField.Size = new System.Drawing.Size(348, 47);
            this.listeningInterfacesField.TabIndex = 1;
            // 
            // authenticationGroupBox
            // 
            this.authenticationGroupBox.Controls.Add(this.passwordField);
            this.authenticationGroupBox.Controls.Add(this.usernameField);
            this.authenticationGroupBox.Controls.Add(this.passwordLabel);
            this.authenticationGroupBox.Controls.Add(this.usernameLabel);
            this.authenticationGroupBox.Location = new System.Drawing.Point(6, 120);
            this.authenticationGroupBox.Name = "authenticationGroupBox";
            this.authenticationGroupBox.Size = new System.Drawing.Size(348, 69);
            this.authenticationGroupBox.TabIndex = 2;
            this.authenticationGroupBox.TabStop = false;
            this.authenticationGroupBox.Text = "Authentication";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(7, 20);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(177, 20);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // usernameField
            // 
            this.usernameField.Location = new System.Drawing.Point(6, 36);
            this.usernameField.MaxLength = 128;
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(165, 20);
            this.usernameField.TabIndex = 1;
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(177, 36);
            this.passwordField.MaxLength = 128;
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(165, 20);
            this.passwordField.TabIndex = 1;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // enableWebServerCheckbox
            // 
            this.enableWebServerCheckbox.AutoSize = true;
            this.enableWebServerCheckbox.Location = new System.Drawing.Point(9, 19);
            this.enableWebServerCheckbox.Name = "enableWebServerCheckbox";
            this.enableWebServerCheckbox.Size = new System.Drawing.Size(119, 17);
            this.enableWebServerCheckbox.TabIndex = 1;
            this.enableWebServerCheckbox.Text = "Enable Web Server";
            this.enableWebServerCheckbox.UseVisualStyleBackColor = true;
            this.enableWebServerCheckbox.CheckedChanged += new System.EventHandler(this.enableWebServerCheckbox_CheckedChanged);
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 430);
            this.Controls.Add(this.webGroupBox);
            this.Controls.Add(this.recordingGroupBox);
            this.Controls.Add(this.cameraGroupBox);
            this.Controls.Add(this.preferencesSaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Preferences";
            this.Text = "Preferences";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Preferences_FormClosing);
            this.Load += new System.EventHandler(this.Preferences_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recordingFrameRate)).EndInit();
            this.cameraGroupBox.ResumeLayout(false);
            this.cameraGroupBox.PerformLayout();
            this.recordingGroupBox.ResumeLayout(false);
            this.recordingGroupBox.PerformLayout();
            this.webGroupBox.ResumeLayout(false);
            this.webGroupBox.PerformLayout();
            this.authenticationGroupBox.ResumeLayout(false);
            this.authenticationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label cameraDeviceLabel;
        private System.Windows.Forms.ComboBox cameraDevicesCombo;
        private System.Windows.Forms.Label resolutionLabel;
        private System.Windows.Forms.ComboBox cameraResolutionCombo;
        private System.Windows.Forms.Label recordingFrameRateLabel;
        private System.Windows.Forms.Label targetDirectoryLabel;
        private System.Windows.Forms.TextBox targetDirectoryField;
        private System.Windows.Forms.Button folderBrowseButton;
        private System.Windows.Forms.Button preferencesSaveButton;
        private System.Windows.Forms.NumericUpDown recordingFrameRate;
        private System.Windows.Forms.GroupBox cameraGroupBox;
        private System.Windows.Forms.GroupBox recordingGroupBox;
        private System.Windows.Forms.GroupBox webGroupBox;
        private System.Windows.Forms.GroupBox authenticationGroupBox;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox listeningInterfacesField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox enableWebServerCheckbox;
    }
}