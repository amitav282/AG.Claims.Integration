using System.Runtime.Serialization;
using AG.Claims.Common;


namespace AG.Claims.Audatex
{
    [DataContract(Namespace = "")]
   public class AudatexResponse : Response
    {
        [DataMember]
        public string Response { get; set; }
    }
}
