using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Xml.Linq;
using System.Web;
using System.Xml;
using System.Windows.Forms;

namespace SolarPowerCalculator_Desktop
{
    public class Rest
    {

        public static string makeRequest(string method, string uriString, string user = "", string password = "", string data = null)
        {

            HttpWebRequest request = HttpWebRequest.Create(uriString) as HttpWebRequest;
            request.Credentials = new NetworkCredential(user, password);
            request.Method = method;
            request.ContentType = "application/x-www-form-urlencoded";
            if (data != null)
            {
                submit(request, data);
            }
            return response(request);

            
        }

        private static void submit(HttpWebRequest request, string data)
        {
            
            byte[] byteData = UTF8Encoding.UTF8.GetBytes(data.ToString());

            using (Stream postStream = request.GetRequestStream())
            {
                postStream.Write(byteData, 0, byteData.Length);
            }

        }

        private static string response(HttpWebRequest request)
        {
            try
            {
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    return reader.ReadToEnd();
                }
            }
            catch (Exception exc)
            {

                restException(exc);
                return null;
            }

        }

        private static void restException(Exception exc)
        {

            MessageBox.Show(exc.Message.ToString(), "Server Connection Error");

        }


    }

}
