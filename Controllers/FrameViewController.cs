using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;

namespace WACCTV.Controllers
{
    class FrameViewController : BaseController
    {
        private ImageConverter converter = new ImageConverter();

        public void Serve(ref HttpListenerContext context, Dictionary<string, object> args)
        {
            Webcam webcam = (Webcam)args["webcam"];

            context.Response.ContentType = "image/jpeg";

            try
            {
                MemoryStream frameStream = new MemoryStream();
                webcam.CurrentFrame.Save(frameStream, ImageFormat.Jpeg);

                byte[] image = frameStream.ToArray();

                context.Response.ContentLength64 = image.Length;
                context.Response.OutputStream.Write(image, 0, image.Length);
            }
            catch { }
            finally
            {
                context.Response.OutputStream.Close();
            }
        }
    }
}
