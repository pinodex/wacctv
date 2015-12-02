using AForge.Video.FFMPEG;

using System;
using System.Drawing;
using System.Windows.Forms;

namespace WACCTV
{
    public class Recording
    {
        private VideoFileWriter videoFileWriter;

        public Recording(Webcam webcam)
        {
            Webcam = webcam;
        }

        private Webcam Webcam
        {
            get;  set;
        }

        public int FrameRate
        {
            get; set;
        }

        public bool IsOpen
        {
            get {
                if (videoFileWriter != null)
                {
                    return videoFileWriter.IsOpen;
                }

                return false;
            }
        }

        public void Init()
        {
            videoFileWriter = new VideoFileWriter();
        }

        public void Open()
        {
            string fileName = Properties.Settings.Default.targetDirectory + "/" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".avi";

            try
            {
                videoFileWriter.Open(
                    fileName,
                    Webcam.CameraResolution.Width,
                    Webcam.CameraResolution.Height,
                    FrameRate,
                    VideoCodec.H263P
                );
            } catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }

        public void AddFrame(Bitmap frame)
        {
            videoFileWriter.WriteVideoFrame(frame);
        }

        public void Close()
        {
            videoFileWriter.Close();
        }
    }
}
