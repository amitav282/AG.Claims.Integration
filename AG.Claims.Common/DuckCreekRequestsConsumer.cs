using System.Configuration;
using System.IO;
using System.Net;
using System.Text;
using System.Xml;

namespace AG.Claims.Common
{
    public class DuckCreekRequestsConsumer
    {
        private string xml = string.Empty;
        public string InputXml
        {
            get { return xml; }
            set
            {
                xml = @"<server><requests><Session.loginRq userName='" + this.UseName + "' password='" + this.Password + "' />" + value + "<Session.closeRq/></requests></server>";
            }
        }

        public string UseName { get; set; }
        public string Password { get; set; }
        public string ServerUrl { get; set; }


        public DuckCreekRequestsConsumer(string serviceUrl = "", string userName = "", string password = "")
        {
            this.ServerUrl = serviceUrl;

            if (ConfigurationManager.AppSettings["ServerUrl"] != null)
                this.ServerUrl = ConfigurationManager.AppSettings["ServerUrl"];
            else
                this.ServerUrl = serviceUrl;

            if (ConfigurationManager.AppSettings["UserName"] != null)
                this.UseName = ConfigurationManager.AppSettings["UserName"];
            else
                this.UseName = userName;

            if (ConfigurationManager.AppSettings["Password"] != null)
                this.Password = ConfigurationManager.AppSettings["Password"];
            else
                this.Password = password;

        }




        public string MakeRequest()
        {
            string responseText = string.Empty;
            HttpWebRequest wr = (HttpWebRequest)HttpWebRequest.Create(ServerUrl);
            wr.Method = "POST";
            wr.KeepAlive = true;
            wr.PreAuthenticate = true;
            wr.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            wr.ContentType = "application/xml";

            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(InputXml);


            byte[] data = Encoding.UTF8.GetBytes(xdoc.InnerXml);
            wr.ContentLength = data.Length;

            using (Stream stream = wr.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            using (WebResponse response = wr.GetResponse())
            {
                using (StreamReader rd = new StreamReader(response.GetResponseStream()))
                {
                    responseText = rd.ReadToEnd();
                }
            }

            return responseText;

        }

    }
}
