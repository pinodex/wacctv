using System.Collections.Generic;
using System.Net;

namespace WACCTV.Controllers
{
    interface BaseController
    {
        void Serve(ref HttpListenerContext context, Dictionary<string, object> args);
    }
}
