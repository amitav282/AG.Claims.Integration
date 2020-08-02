using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AG.Claims.Common
{

    [DataContract(Namespace = "")]
    [JsonObject(MemberSerialization.OptOut)]
    public class Response : IBaseContract
    {
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public string Status { get; set; }
    }
}
