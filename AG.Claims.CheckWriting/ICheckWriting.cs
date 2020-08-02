using System.ServiceModel;
using System.ServiceModel.Web;
using AG.Claims.Integration.Types;

namespace AG.Claims.CheckWriting
{
    [ServiceContract]
    public interface ICheckWriting
    {
        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Bare,ResponseFormat=WebMessageFormat.Json)]
        ChequeResponse GetCheckPrintingInformation();

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        ChequeResponse UpdateCheckDetail(AG_ClaimCheckWritingDTO[] checkDetail);

    }
}
