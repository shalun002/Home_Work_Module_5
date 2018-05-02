using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Url.Module
{
    public class EnterUrl
    {
        public void SetUrl()
        {
            try
            {
                string url = Console.ReadLine();
                string temp = Get(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Page not found " + ex.Message);
                Console.ReadLine();
            }
        }

        public static string Get(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
            throw new NotImplementedException();
        }
    }
}