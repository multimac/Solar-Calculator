using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace SolarCalculator
{
    public enum RequestMethod
    {
        GET,
        POST,
    }

    public enum ContentType
    {
        Text,
        Text_HTML,
        Text_XML,
    }

    static class RESTMethods
    {
        private static string[] contentTypes = { "text/*", "text/html", "text/xml" };

        public static string Request(Uri target, RequestMethod method)
        {
            return Request(target, method, ContentType.Text_XML, null);
        }
        public static string Request(Uri target, RequestMethod method, ContentType type, byte[] data)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(target); // Perform a GET request for the site
            request.Method = method.ToString();
            
            Stream stream;
            if (method == RequestMethod.POST) // Set the ContentType and ContentLength required for doing a POST
            {
                request.ContentType = contentTypes[(int)type];
                request.ContentLength = data.Length;

                stream = request.GetRequestStream(); // Upload data for POST
                stream.Write(data, 0, data.Length);
                stream.Close();
            }

            HttpWebResponse response;
            try
            {
                response = (HttpWebResponse)request.GetResponse(); // Retrieve the response from the server
            }
            catch { return null; }
            stream = response.GetResponseStream();

            string responseString = "";
            int count = 0;

            byte[] buffer = new byte[4196];
            do // Read the response into a string
            {
                count = stream.Read(buffer, 0, buffer.Length);

                if (count != 0)
                    responseString += Encoding.ASCII.GetString(buffer, 0, count);

            } while (count > 0);

            stream.Close();

            return responseString;
        }
    }
}
