using System.ServiceModel;
using System.ServiceModel.Web;
using AG.Claims.Common;
using AG.Claims.Integration.Types;

namespace AG.Claims.ClueDataExchange
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IClueDataExchangeService" in both code and config file together.
    [ServiceContract]
    public interface IClueDataExchange
    {
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare)]
        Response SendDataToClue(ClueDTOs clueDTOs);
    }
}
