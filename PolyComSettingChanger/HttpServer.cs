using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PolyComSettingChanger
{
    class HttpServer
    {


       public void ProcessRequest(HttpListenerContext context)
        {
            // Get the data from the HTTP stream
            var body = new StreamReader(context.Request.InputStream).ReadToEnd();

            //Saving response to xml
            File.WriteAllText("F:\\PolycomCall" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".xml", body, Encoding.ASCII);


            //USE THIS TO SEND SCRIPT TO REQUESTED CLIENT
            //byte[] b = Encoding.UTF8.GetBytes("<script>alert('Welcome to my Http Server')</script>");
            //context.Response.StatusCode = 200;
            //context.Response.KeepAlive = false;
            //context.Response.ContentLength64 = b.Length;

            //var output = context.Response.OutputStream;
            //output.Write(b, 0, b.Length);
            //context.Response.Close();
        }

        public void StartHttpListener(string ListenIp)
        {

            var web = new HttpListener();
            web.Prefixes.Add(ListenIp);
            web.AuthenticationSchemes = AuthenticationSchemes.Anonymous;


            web.Start();
            while (true)
            {

                var context = web.GetContext();
                ProcessRequest(context);
                var response = context.Response;

            }

        }


    }
}
