using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Xml;
using Newtonsoft.Json;

namespace AG.Claims.Common
{
    public class ServiceConsumer
    {
        public XmlDocument Input { get; private set; }
        public string ContentType { get; private set; }
        public Uri ServiceUri { get; private set; }


        /// <summary>
        ///     
        /// </summary>
        /// <param name="method">Http methods</param>
        /// <param name="uri"> Service URL</param>
        /// <param name="input"> input to  service</param>
        /// <param name="contentType"> Input type to service</param>
        /// <param name="acceptType"> response type from service</param>
        public ServiceConsumer(XmlDocument input, string contentType, string serviceUrl)
        {
            Input = input;
            ContentType = contentType;
            ServiceUri = new Uri(serviceUrl);
        }


        public string Consume()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = this.ServiceUri;
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(this.ContentType));
            HttpResponseMessage response = client.PostAsync(this.ServiceUri.AbsoluteUri, new StringContent(this.Input.InnerXml)).Result;
            return response.Content.ReadAsStringAsync().Result;
        }
        /// <summary>
        /// To serialize to json
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objectToSerialise"></param>
        /// <returns></returns>
        public static string ToJson<T>(T objectToSerialise)
        {
            JsonSerializerSettings microsoftDateFormatSettings = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
            };
            var param = JsonConvert.SerializeObject(objectToSerialise, microsoftDateFormatSettings);
            return param;
        }

    }

}
