using AForge.Video;
using AForge.Video.DirectShow;

using System;
using System.Drawing;
using System.Windows.Forms;

namespace WACCTV
{
    public class FrameUpdateEventArgs : EventArgs
    {
        public Bitmap Frame {
            get; set;
        }

        public bool IsError
        {
            get; set;
        }
    }

    public class Webcam
    {
        private FilterInfoCollection devices;
        private VideoCaptureDevice videoCaptureDevice;

        private RectangleF frameRectF;

        public delegate void FrameUpdateEvent(object sender, FrameUpdateEventArgs e);
        public event FrameUpdateEvent FrameUpdate;

        public delegate void WebcamInitEvent();
        public event WebcamInitEvent WebcamInit;

        private FrameUpdateEventArgs frameUpdateEventArgs;
        
        public Webcam()
        {
            frameUpdateEventArgs = new FrameUpdateEventArgs();
        }

        public bool IsRunning
        {
            get
            {
                if (videoCaptureDevice != null)
                {
                    return videoCaptureDevice.IsRunning;
                }

                return false;
            }
        }

        public string DeviceName
        {
            get; private set;
        }

        public string DeviceMoniker
        {
            get; set;
        }

        public Resolution CameraResolution
        {
            get; set;
        }

        public Bitmap CurrentFrame
        {
            get; set;
        }

        public void Init()
        {
            DeviceName = null;
            devices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (string.IsNullOrEmpty(DeviceMoniker))
            {
                MessageBox.Show("Please set video capture device in the preferences.");
                return;
            }

            videoCaptureDevice = new VideoCaptureDevice(DeviceMoniker);

            if (videoCaptureDevice.VideoCapabilities.Length > 0) {
                for (int i = 0; i < videoCaptureDevice.VideoCapabilities.Length; i++)
                {
                    if (videoCaptureDevice.VideoCapabilities[i].FrameSize.Width == CameraResolution.Width)
                    {
                        videoCaptureDevice.VideoResolution = videoCaptureDevice.VideoCapabilities[i];
                        break;
                    }
                }
            }

            foreach (FilterInfo device in devices)
            {
                if (device.MonikerString.Equals(DeviceMoniker))
                {
                    DeviceName = device.Name;
                }
            }

            videoCaptureDevice.NewFrame += DrawOverlays;
            videoCaptureDevice.VideoSourceError += HandleSourceError;
            videoCaptureDevice.PlayingFinished += HandleFinishedPlaying;

            frameRectF = new RectangleF(0, 0, CameraResolution.Width, CameraResolution.Height);

            if (WebcamInit != null)
            {
                WebcamInit();
            }
        }

        public void Start()
        {
            if (videoCaptureDevice != null)
            {
                videoCaptureDevice.Start();
            }
        }

        public void Stop()
        {
            if (videoCaptureDevice != null)
            {
                videoCaptureDevice.SignalToStop();
                videoCaptureDevice = null;
            }
        }

        public void Restart()
        {
            Stop();
            Init();
            Start();
        }

        private void DrawOverlays(object sender, NewFrameEventArgs e)
        {
            string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            Bitmap bitmap = e.Frame;
            Overlays.Draw(ref bitmap, dateTime);

            if (FrameUpdate != null)
            {
                CurrentFrame = (Bitmap)bitmap.Clone();

                frameUpdateEventArgs.Frame = bitmap;
                frameUpdateEventArgs.IsError = false;

                FrameUpdate(this, frameUpdateEventArgs);
            }
        }

        private void HandleFinishedPlaying(object sender, ReasonToFinishPlaying e)
        {
            string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            Bitmap bitmap = new Bitmap(CameraResolution.Width, CameraResolution.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            
            graphics.FillRectangle(Brushes.Blue, frameRectF);

            Overlays.Draw(ref bitmap, dateTime + "\nNO SIGNAL");

            if (FrameUpdate != null)
            {
                CurrentFrame = (Bitmap)bitmap.Clone();

                frameUpdateEventArgs.Frame = bitmap;
                frameUpdateEventArgs.IsError = true;

                FrameUpdate(this, frameUpdateEventArgs);
            }
        }

        private void HandleSourceError(object sender, VideoSourceErrorEventArgs e)
        {
            HandleFinishedPlaying(sender, ReasonToFinishPlaying.VideoSourceError);
        }
    }
}
