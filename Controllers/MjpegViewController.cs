using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Text;

namespace WACCTV.Controllers
{
    class MjpegViewController : BaseController
    {
        private ImageConverter converter = new ImageConverter();

        public void Serve(ref HttpListenerContext context, Dictionary<string, object> args)
        {
            Webcam webcam = (Webcam)args["webcam"];
            
            context.Response.ContentType = "multipart/x-mixed-replace; boundary=--wacctv-boundary";

            try
            {
                while (true)
                {
                    MemoryStream frameStream = new MemoryStream();
                    webcam.CurrentFrame.Save(frameStream, ImageFormat.Jpeg);

                    byte[] image = frameStream.ToArray();
                    byte[] header = Encoding.UTF8.GetBytes(
                        "\r\n" +
                        "--wacctv-boundary\r\n" +
                        "Content-Type: image/jpeg\r\n" +
                        "Content-Length: " + image.Length + "\r\n\r\n"
                    );
                    
                    context.Response.OutputStream.Write(header, 0, header.Length);
                    context.Response.OutputStream.Write(image, 0, image.Length);

                    context.Response.OutputStream.Flush();
                }
            }
            catch { }
            finally
            {
                context.Response.OutputStream.Close();
            }
        }
    }
}
