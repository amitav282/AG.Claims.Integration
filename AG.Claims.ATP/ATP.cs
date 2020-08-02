using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Reflection;
using System.Configuration;
using Newtonsoft.Json;
using AG.Claims.ATP.DataContract;
using AG.Claims.Integration.Types;
using AG.Claims.Common;

namespace AG.Claims.ATP
{
    public class ATP
    {
        #region Property
        private string tokenHashKey;
        #endregion
        #region Declarations
        private Token tokenDetails = null;
        private InsuranceCompany insuranceCompany = null;
        #endregion
        #region Constructor
        /// <summary>
        /// Default Constructor for the class
        /// </summary>
        public ATP()
        {
            tokenHashKey = Guid.NewGuid().ToString();
            tokenDetails = new Token();
            insuranceCompany = new InsuranceCompany();
        }

        #endregion
        #region Public Methods
        /// <summary>
        /// Initiates the call to ATP
        /// </summary>
        /// <param name="inputAssignment"></param>
        /// <returns>ResponseDetails class as an object</returns>
        public ResponseDetails InitiateATPCall(Assignment inputAssignment)
        {
            ResponseDetails response = new ResponseDetails();
            response = SendTokenRequest();
            if (response.Token != null)
            {
                inputAssignment.Carrier = GetInsuranceCompanies(response.Token);
                response = SendAssignmentRequest(response.Token, inputAssignment);
            }
            return response;
        }
        #endregion
        #region Private Methods
        /// <summary>
        /// Send a request to get the token
        /// </summary>
        /// <returns>ResponseDetails class as an object</returns>
        private ResponseDetails SendTokenRequest()
        {
            Uri tokenDetailsURI = new Uri(ConfigurationManager.AppSettings["TokenDetailsURI"].ToString());
            string apiKey = ConfigurationManager.AppSettings["ApiKey"];
            int apiUserID = Convert.ToInt16(ConfigurationManager.AppSettings["ApiUserID"]);
            tokenDetails.ApiHash = tokenHashKey;
            tokenDetails.ApiKey = apiKey;
            tokenDetails.ApiUserID = apiUserID;
            return XmlHttpRequest(tokenDetailsURI.ToString(), ConvertObjectToString(tokenDetails));

        }
        /// <summary>
        /// Gets the collection of insurance companies from ATP
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        private string GetInsuranceCompanies(string token)
        {
            Uri insuranceComapanyURI = new Uri(ConfigurationManager.AppSettings["InsuranceCompanyURI"].ToString());
            string companyID = string.Empty;
            Dictionary<string, string> insuranceCompanyName = new Dictionary<string, string>();
            insuranceCompany.ApiHash = tokenHashKey;
            insuranceCompany.ApiToken = token;
            insuranceCompanyName = XmlHttpRequestInsurance(insuranceComapanyURI.ToString(), ConvertObjectToString(insuranceCompany));
            if (insuranceCompanyName.Count > 0)
            {
                companyID = insuranceCompanyName.FirstOrDefault(x => x.Value == "Anchor General Insurance Company").Key;

            }
            return companyID;
        }
        /// <summary>
        /// Send the Assignment request to ATP
        /// </summary>
        /// <param name="token"></param>
        /// <param name="inputAssignment"></param>
        /// <returns>ResponseDetails class as an object</returns>
        private ResponseDetails SendAssignmentRequest(string token, Assignment inputAssignment)
        {
            Uri assignementRequestURI = new Uri(ConfigurationManager.AppSettings["AssignmentRequestURI"].ToString());
            inputAssignment.ApiToken = token;
            inputAssignment.ApiHash = tokenHashKey;
            return XmlHttpRequest(assignementRequestURI.ToString(), ConvertObjectToString(inputAssignment));
        }
        /// <summary>
        /// Takes a object and creates a string with the property Names
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private string ConvertObjectToString(object input)
        {
            string data = string.Empty;
            if (input == null) return data;
            Type t = input.GetType();
            PropertyInfo[] props = t.GetProperties();
            string name = string.Empty;
            foreach (PropertyInfo prp in props)
            {
                foreach (CustomAttributeData attribData in prp.GetCustomAttributesData())
                {
                    name = attribData.NamedArguments[0].TypedValue.Value.ToString();
                }
                object value = prp.GetValue(input, new object[] { });
                data = data + name + "=" + value + "&";
            }
            return data.Remove(data.Length - 1);
        }
        /// <summary>
        /// Calls the HTTP Request method to connect to a Web API
        /// </summary>
        /// <param name="urlString"></param>
        /// <param name="xmlContent"></param>
        /// <returns>ResponseDetails class as an object</returns>
        private ResponseDetails XmlHttpRequest(string urlString, string xmlContent)
        {
            HttpWebResponse httpWebResponse = null;
            ResponseDetails responseData = new ResponseDetails();
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(urlString);
            try
            {
                httpWebRequest.Method = "POST";
                httpWebRequest.ContentType = "application/x-www-form-urlencoded";
                httpWebRequest.UserAgent = string.Empty;
                httpWebRequest.Accept = "*/*";
                httpWebRequest.Headers.Add("X-Requested-With", "XMLHttpRequest");
                using (StreamWriter writer = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    writer.Write(xmlContent);
                }
                //Sends the HttpWebRequest, and waits for a response.
                httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                if (httpWebResponse.StatusCode == HttpStatusCode.OK)
                {
                    //Get response stream into StreamReader
                    using (Stream responseStream = httpWebResponse.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                            responseData = JsonConvert.DeserializeObject<ResponseDetails>(reader.ReadToEnd());
                    }
                }
                string deserialzedObject = JsonConvert.SerializeObject(responseData);
                Log.CreateLog($"Received ATP Response string is :-  {deserialzedObject}", Level.Info);
                httpWebResponse.Close();//Close HttpWebResponse
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (httpWebResponse != null)
                {
                    httpWebResponse.Close();
                    httpWebResponse = null;
                    httpWebRequest = null;
                }

            }
            return responseData;
        }

        private Dictionary<string, string> XmlHttpRequestInsurance(string urlString, string xmlContent)
        {
            HttpWebResponse httpWebResponse = null;
            Dictionary<string, string> responseData = new Dictionary<string, string>();
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(urlString);
            try
            {
                httpWebRequest.Method = "POST";
                httpWebRequest.ContentType = "application/x-www-form-urlencoded";
                httpWebRequest.UserAgent = string.Empty;
                httpWebRequest.Accept = "*/*";
                httpWebRequest.Headers.Add("X-Requested-With", "XMLHttpRequest");
                using (StreamWriter writer = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    writer.Write(xmlContent);
                }
                //Sends the HttpWebRequest, and waits for a response.
                httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                if (httpWebResponse.StatusCode == HttpStatusCode.OK)
                {
                    //Get response stream into StreamReader
                    using (Stream responseStream = httpWebResponse.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                            responseData = JsonConvert.DeserializeObject<Dictionary<string, string>>(reader.ReadToEnd());
                    }
                }
                httpWebResponse.Close();//Close HttpWebResponse
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                if (httpWebResponse != null)
                {
                    httpWebResponse.Close();
                    httpWebResponse = null;
                    httpWebRequest = null;
                }

            }
            return responseData;
        }
        #endregion
    }
}
