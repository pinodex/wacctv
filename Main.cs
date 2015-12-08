using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace WACCTV
{
    public partial class Main : Form
    {
        Webcam webcam;
        Recording recording;
        bool fullScreen;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            webcamView.SizeMode = Properties.Settings.Default.zoomMode;

            webcam = new Webcam();
            recording = new Recording(webcam);

            webcam.DeviceMoniker = Properties.Settings.Default.cameraDevice;

            if (Properties.Settings.Default.cameraResolution != null)
            {
                webcam.CameraResolution = new Resolution(Properties.Settings.Default.cameraResolution);
            }

            webcam.Init();
            webcam.Start();

            recording.Init();
            recording.FrameRate = 30;

            if (Properties.Settings.Default.enableWebServer)
            {
                WebMonitor.Init();

                WebMonitor.Webcam = webcam;
                WebMonitor.Username = Properties.Settings.Default.webUsername;
                WebMonitor.Password = Properties.Settings.Default.webPassword;

                Thread webMonitorServerThread = new Thread(WebMonitor.Start);
                webMonitorServerThread.Start();
            }

            webcam.FrameUpdate += FrameUpdateHandler;
            webcam.WebcamInit += WebcamInitHandler;

            UpdateUi(null, null);

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += UpdateUi;
            timer.Start();
        }

        private void UpdateUi(object sender, EventArgs e)
        {
            statusInfo.Text = DateTime.Now.ToString("hh:mm:ss tt");

            if (recording != null && recording.IsOpen)
            {
                statusInfo.Text += " Recording";
                viewRecordingLabel.Visible = fullScreen;
            }

            if (!string.IsNullOrEmpty(webcam.DeviceMoniker) && !webcam.IsRunning)
            {
                webcam.Restart();
            }
        }

        private void WebcamInitHandler()
        {
            if (webcam.DeviceName == null)
            {
                statusDeviceName.Text = "Unknown Device";

                return;
            }

            statusDeviceName.Text = webcam.DeviceName;
            recording.FrameRate = (int)Properties.Settings.Default.recordingFrameRate;
        }

        private void FrameUpdateHandler(object sender, FrameUpdateEventArgs e)
        {
            try {
                webcamView.Image = (Bitmap)e.Frame.Clone();

                if (recording != null && recording.IsOpen)
                {
                    if (!e.IsError)
                    {
                        recording.AddFrame(e.Frame);
                    }

                    if (e.IsError)
                    {
                        for (int i = 0; i < Math.Round((double)recording.FrameRate / 2); i++)
                        {
                            recording.AddFrame(e.Frame);
                        }
                    }

                    e.Frame.Dispose();
                }
            }
            catch {}
        }

        private void ToggleFullscreen()
        {
            if (fullScreen)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Maximized;

                menuStrip.Visible = true;
                statusStrip.Visible = true;

                viewRecordingLabel.Visible = false;

                fullScreen = false;

                return;
            }

            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            menuStrip.Visible = false;
            statusStrip.Visible = false;

            if (recording != null && recording.IsOpen)
            {
                viewRecordingLabel.Visible = true;
            }

            fullScreen = true;
        }

        private void menuItemClicked(object sender, EventArgs e)
        {
            string itemName = ((ToolStripMenuItem)sender).Name;

            switch (itemName)
            {
                case "preferencesToolStripMenuItem":
                    Preferences preferences = new Preferences();
                    preferences.Webcam = webcam;
                    preferences.Show();

                    break;

                case "toggleFullscreenToolStripMenuItem":
                    ToggleFullscreen();

                    break;

                case "fitToolStripMenuItem":
                    Properties.Settings.Default.zoomMode = PictureBoxSizeMode.Zoom;
                    webcamView.SizeMode = PictureBoxSizeMode.Zoom;

                    Properties.Settings.Default.Save();

                    break;

                case "stretchToolStripMenuItem":
                    Properties.Settings.Default.zoomMode = PictureBoxSizeMode.StretchImage;
                    webcamView.SizeMode = PictureBoxSizeMode.StretchImage;

                    Properties.Settings.Default.Save();

                    break;

                case "startToolStripMenuItem":
                    startToolStripMenuItem.Enabled = false;
                    stopToolStripMenuItem.Enabled = true;
                    preferencesToolStripMenuItem.Enabled = false;

                    recording.Open();

                    break;

                case "stopToolStripMenuItem":
                    startToolStripMenuItem.Enabled = true;
                    stopToolStripMenuItem.Enabled = false;
                    preferencesToolStripMenuItem.Enabled = true;

                    recording.Close();

                    break;

                case "Exit":
                    Close();

                    break;
            }
        }

        private void Main_Form_Closing(object sender, FormClosingEventArgs e)
        {
            if (recording.IsOpen)
            {
                recording.Close();
            }

            if (webcam.IsRunning)
            {
                webcam.Stop();
            }

            if (WebMonitor.IsListening)
            {
                WebMonitor.Stop();
            }
        }

        private void webcamView_DoubleClick(object sender, EventArgs e)
        {
            ToggleFullscreen();
        }
    }
}
