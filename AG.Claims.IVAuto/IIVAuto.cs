using System.ServiceModel;
using System.ServiceModel.Web;
using AG.Claims.Integration.Types;

namespace AG.Claims.IVAuto
{
    /// <summary>
    /// Interface
    /// </summary>
    /// <param name="inputAssignment"></param>
    /// <returns></returns>
    [ServiceContract]
    public interface IIVAuto
    {
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare)]
        IVAutoResponse SendDataToIVAUTO(AssignmentIVAuto inputAssignment);
    }
}
