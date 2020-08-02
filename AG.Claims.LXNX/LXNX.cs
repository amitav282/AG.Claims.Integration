using System.Configuration;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Net;
using System;
using System.Text;
using AG.Claims.Integration.Types;
using AG.Claims.Common;

namespace AG.Claims.LXNX
{
    public class LXNX
    {
        #region Public Methods
        /// <summary>
        /// Sends the request to LexisNexis
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public LXNXResponse SendAssignmentRequest(order input)
        {
            LXNXResponse response = new LXNXResponse();
            string output = string.Empty;
            try
            {
                AG_CCR.ohwsClient lexisNexisClient = new AG_CCR.ohwsClient();
                lexisNexisClient.ClientCredentials.UserName.UserName = ConfigurationManager.AppSettings["LXNXUserName"];
                lexisNexisClient.ClientCredentials.UserName.Password = ConfigurationManager.AppSettings["LXNXPassword"];

                using (OperationContextScope opScope = new OperationContextScope(lexisNexisClient.InnerChannel))
                {
                    HttpRequestMessageProperty httpRequestProperty = new HttpRequestMessageProperty();
                    httpRequestProperty.Headers[HttpRequestHeader.Authorization] = "Basic " +
                    Convert.ToBase64String(Encoding.ASCII.GetBytes(lexisNexisClient.ClientCredentials.UserName.UserName + ":" +
                    lexisNexisClient.ClientCredentials.UserName.Password));
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] =
                       httpRequestProperty;

                    output = lexisNexisClient.PlaceInteractiveOrder(CreateXML(input));                    
                }
            }
            catch (FaultException<AG_CCR.SOAPFaultInfo> exa)
            {
                Log.CreateLog("Error Code - " + exa.Detail.code + " : Error - " + exa.Detail.message , Level.Info);
                throw exa;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Log.CreateLog($"Received LXNX Response string is :-  {output}", Level.Info);
            XmlSerializer serializer = new XmlSerializer(typeof(Result));
            StringReader rdr = new StringReader(output);
            Result resultingMessage = (Result)serializer.Deserialize(rdr);
            if (resultingMessage != null)
            {
                if (resultingMessage.messages != null)
                {
                    foreach (Message mes in resultingMessage.messages)
                    {
                        if (mes.Type == "Error")
                        {
                            response.LXResponse = mes.Value;
                            response.Message = mes.Code;
                            response.Status = "LXNXError";
                            break;
                        }
                        else
                        {
                            response.Status = string.Empty;
                        }
                    }
                }
            }
            if(response.Status != "LXNXError")
            {
                response.LXResponse = resultingMessage.ProductResults.ClaimsFill.FormatReport.ReportField.Value;
                response.Message = "RequestSuccessful";
                response.Status = "Success";
            }
            return response;
        }
        #endregion
        #region Private Methods
        /// <summary>
        /// Converts the input object to xml string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private string CreateXML(order input)
        {
            XmlDocument xmlDoc = new XmlDocument();   //Represents an XML document, 
                                                      // Initializes a new instance of the XmlDocument class.          
            XmlSerializer xmlSerializer = new XmlSerializer(input.GetType());
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("","http://cp.com/rules/client");
            // Creates a stream whose backing store is memory. 
            using (MemoryStream xmlStream = new MemoryStream())
            {
                xmlSerializer.Serialize(xmlStream, input, ns);
                xmlStream.Position = 0;
                //Loads the XML document from the specified string.
                xmlDoc.Load(xmlStream);
                Log.CreateLog($"Request Xml String :-   {xmlDoc.InnerXml}", Level.Info);
                return xmlDoc.InnerXml;
            }
        }
        #endregion
    }
}
