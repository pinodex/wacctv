using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WACCTV
{
    public partial class Preferences : Form
    {
        public Preferences()
        {
            InitializeComponent();
        }

        FilterInfoCollection videoSources;
        VideoCaptureDevice videoCaptureDevice;
        Dictionary<string, string> videoSourcesNames, videoSourcesMonikers;

        string cameraResolution, cameraDevice, networkInterfaces;

        public Webcam Webcam
        {
            get; set;
        }

        private void Preferences_Load(object sender, EventArgs e)
        {
            videoSources = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoSourcesNames = new Dictionary<string, string>();
            videoSourcesMonikers = new Dictionary<string, string>();

            cameraDevice = Properties.Settings.Default.cameraDevice;
            networkInterfaces = Properties.Settings.Default.listeningInterfaces;

            foreach (FilterInfo videoSource in videoSources)
            {
                cameraDevicesCombo.Items.Add(videoSource.Name);

                videoSourcesNames.Add(videoSource.MonikerString, videoSource.Name);
                videoSourcesMonikers.Add(videoSource.Name, videoSource.MonikerString);
            }

            if (cameraDevice != null)
            {
                try
                {
                    cameraDevicesCombo.SelectedIndex = cameraDevicesCombo.Items.IndexOf(videoSourcesNames[cameraDevice]);
                } catch (Exception)
                {
                    cameraDevicesCombo.SelectedIndex = 0;
                }
            }

            recordingFrameRate.Value = Properties.Settings.Default.recordingFrameRate;
            targetDirectoryField.Text = Properties.Settings.Default.targetDirectory;
            enableWebServerCheckbox.Checked = Properties.Settings.Default.enableWebServer;
            listeningInterfacesField.Text = Properties.Settings.Default.listeningInterfaces;
            usernameField.Text = Properties.Settings.Default.webUsername;
            passwordField.Text = Properties.Settings.Default.webPassword;

            listeningInterfacesField.Enabled = enableWebServerCheckbox.Checked;
            usernameField.Enabled = enableWebServerCheckbox.Checked;
            passwordField.Enabled = enableWebServerCheckbox.Checked;
        }

        private void cameraDevicesCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            cameraResolutionCombo.Items.Clear();

            videoCaptureDevice = new VideoCaptureDevice(videoSourcesMonikers[cameraDevicesCombo.Text]);

            foreach (VideoCapabilities videoCapabilities in videoCaptureDevice.VideoCapabilities)
            {
                cameraResolutionCombo.Items.Add(
                    videoCapabilities.FrameSize.Width + "x" +
                    videoCapabilities.FrameSize.Height
                );
            }

            cameraResolution = Properties.Settings.Default.cameraResolution;

            cameraResolutionCombo.SelectedIndex = 0;

            if (cameraResolution != null && cameraResolutionCombo.Items.Contains(cameraResolution))
            {
                cameraResolutionCombo.SelectedIndex = cameraResolutionCombo.Items.IndexOf(cameraResolution);
            }
        }

        private void preferencesSaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.cameraDevice = videoSourcesMonikers[cameraDevicesCombo.Text];
            Properties.Settings.Default.cameraResolution = cameraResolutionCombo.Text;
            Properties.Settings.Default.recordingFrameRate = recordingFrameRate.Value;
            Properties.Settings.Default.targetDirectory = targetDirectoryField.Text;
            Properties.Settings.Default.enableWebServer = enableWebServerCheckbox.Checked;
            Properties.Settings.Default.listeningInterfaces = listeningInterfacesField.Text;
            Properties.Settings.Default.webUsername = usernameField.Text;
            Properties.Settings.Default.webPassword = passwordField.Text;

            Properties.Settings.Default.Save();

            Webcam.DeviceMoniker = Properties.Settings.Default.cameraDevice;
            Webcam.CameraResolution = new Resolution(Properties.Settings.Default.cameraResolution);

            WebMonitor.Username = usernameField.Text;
            WebMonitor.Password = passwordField.Text;

            this.Close();
        }

        private void folderBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();

            targetDirectoryField.Text = folderBrowserDialog.SelectedPath;
        }

        private void enableWebServerCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            listeningInterfacesField.Enabled = enableWebServerCheckbox.Checked;
            usernameField.Enabled = enableWebServerCheckbox.Checked;
            passwordField.Enabled = enableWebServerCheckbox.Checked;
        }

        private void Preferences_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cameraDevice != Properties.Settings.Default.cameraDevice ||
                cameraResolution != Properties.Settings.Default.cameraResolution)
            {
                Webcam.Restart();
            }

            if (networkInterfaces != Properties.Settings.Default.listeningInterfaces)
            {
                MessageBox.Show("You must restart the application before changes in listening interfaces apply.");
            }

            if (Properties.Settings.Default.enableWebServer && !WebMonitor.IsListening)
            {
                WebMonitor.Init();
                WebMonitor.Start();
            }

            if (!Properties.Settings.Default.enableWebServer && WebMonitor.IsListening)
            {
                WebMonitor.Stop();
            }
        }
    }
}
