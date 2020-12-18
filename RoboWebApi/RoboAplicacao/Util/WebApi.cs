using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RoboAplicacao.Util
{
    public class WebApi
    {
        public static string URI = "https://localhost:44384/api/";
        
        private static string RequesteGET_DELETE(string metodo, string parametro, string tipo)
        {
            var request = (HttpWebRequest)WebRequest.Create(URI + metodo + "/" + parametro);
            request.ServicePoint.Expect100Continue = false;
            request.Method = tipo;
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new System.IO.StreamReader(response.GetResponseStream()).ReadToEnd();
            return responseString;
        }

        public static string RequestGET(string metodo, string parametro)
        {
            return RequesteGET_DELETE(metodo, parametro, "GET");
        }

        public static string RequestPUT(string metodo, string jsonData)
        {
            var request = (HttpWebRequest)WebRequest.Create(URI + metodo);
            var data = Encoding.ASCII.GetBytes(jsonData);
            request.Method = "PUT";
            request.ContentType = "application/json";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;
        }
    }
}
