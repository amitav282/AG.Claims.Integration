using System.ServiceModel;
using System.ServiceModel.Web;

namespace AG.Claims.Audatex
{
    [ServiceContract]
    public interface IAudatexService
    {
        /// <summary>
        /// Uploads the Response xml's from Audatex to FileNote
        /// </summary>
        /// <param name="audatexDetails"></param>
        /// <returns>AudatexResponse object</returns>
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        AudatexResponse UploadAudatexResponse(string audatexDetails);
        /// <summary>
        /// Sends the data from service to Audatex
        /// </summary>
        /// <param name="audatexDetails"></param>
        /// <returns>AudatexResponse object</returns>>
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        AudatexResponse SendAsignmentRequest(Integration.Types.AssignmentAddRq audatexInput);
    }
}
