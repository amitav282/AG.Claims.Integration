using System.ServiceModel;
using System.ServiceModel.Web;
using AG.Claims.ATP.DataContract;
using AG.Claims.Integration.Types;

namespace AG.Claims.ATP
{
    [ServiceContract]
    public interface IATP
    {
        /// <summary>
        /// Interface
        /// </summary>
        /// <param name="inputAssignment"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Bare)]
        ResponseDetails SendDataToATP(Assignment inputAssignment);
    }
}
