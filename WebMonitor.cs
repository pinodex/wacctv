using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Windows.Forms;
using WACCTV.Controllers;

namespace WACCTV
{
    public class WebMonitor
    {
        private readonly static Dictionary<string, string> mimeList = new Dictionary<string, string>
        {
            {"html", "text/html"},
            {"htm", "text/html"},
            {"js", "text/javascript"},
            {"css", "text/css"},
            {"jpg", "image/jpg"},
            {"png", "image/png"}
        };

        private static Dictionary<string, BaseController> routes;

        private static HttpListener HttpListener
        {
            get; set;
        }

        public static string Username
        {
            get; set;
        }

        public static string Password
        {
            get; set;
        }

        public static Webcam Webcam
        {
            get; set;
        }

        public static bool IsListening
        {
            get
            {
                if (HttpListener == null)
                {
                    return false;
                }

                return HttpListener.IsListening;
            }
        }

        public static void Init()
        {
            routes = new Dictionary<string, BaseController>
            {
                {"/frame", new FrameViewController()},
                {"/mjpeg", new MjpegViewController()}
            };

            HttpListener = new HttpListener();

            string[] prefixes = Properties.Settings.Default.listeningInterfaces.Split('\n');

            for (int i = 0; i < prefixes.Length; i++)
            {
                HttpListener.Prefixes.Add("http://" + prefixes[i] + "/");
            }

            HttpListener.AuthenticationSchemes = AuthenticationSchemes.Basic;
            HttpListener.Realm = "WACCTV";
        }
        
        public static void Start()
        {
            try
            {
                HttpListener.Start();
                IAsyncResult context = HttpListener.BeginGetContext(new AsyncCallback(Serve), HttpListener);
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to start web server\n\n" + e.Message, "Error");
            }
        }

        public static void Stop()
        {
            HttpListener.Stop();
        }

        private static void Authenticate(HttpListenerContext context, HttpListenerBasicIdentity identity)
        {
            if (Username != identity.Name || Password != identity.Password)
            {
                context.Response.AddHeader("WWW-Authenticate", "Basic Realm=\"" + HttpListener.Realm + "\"");
                context.Response.StatusCode = 401;
                context.Response.Close();

                throw new UnauthorizedAccessException();
            }
        }

        private static void Serve(IAsyncResult result)
        {
            HttpListener listener = (HttpListener)result.AsyncState;

            try {
                HttpListenerContext context = listener.EndGetContext(result);
                HttpListenerBasicIdentity identity = (HttpListenerBasicIdentity)context.User.Identity;

                listener.BeginGetContext(Serve, listener);
                Authenticate(context, identity);

                if (routes.ContainsKey(context.Request.RawUrl))
                {
                    context.Response.StatusCode = 200;
                    context.Response.SendChunked = true;

                    BaseController controller;
                    Dictionary<string, object> args = new Dictionary<string, object>
                    {
                        {"webcam", Webcam}
                    };

                    routes.TryGetValue(context.Request.RawUrl, out controller);

                    controller.Serve(ref context, args);
                    return;
                }

                string responseString = "404 Not Found";
                byte[] buffer = Encoding.UTF8.GetBytes(responseString);

                context.Response.StatusCode = 404;
                context.Response.ContentLength64 = buffer.Length;
                context.Response.OutputStream.Write(buffer, 0, buffer.Length);
                context.Response.OutputStream.Close();
            }
            catch { }
        }
    }
}
