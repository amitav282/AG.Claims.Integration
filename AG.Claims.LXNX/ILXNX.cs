using System.ServiceModel;
using System.ServiceModel.Web;
using AG.Claims.Integration.Types;

namespace AG.Claims.LXNX
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILXNXService" in both code and config file together.
    [ServiceContract]
        public interface ILXNX
        {
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        LXNXResponse SendAssignmentRequest(order input);
        }
    }

