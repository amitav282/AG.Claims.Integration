using System.Runtime.Serialization;
using AG.Claims.Common;
using AG.Claims.Integration.Types;


namespace AG.Claims.CheckWriting
{
    [DataContract(Namespace = "")]
    public class ChequeResponse: Response
    {
        [DataMember]
       public AG_ClaimCheckWritingDTO[] CheckDetail { get; set; }

    }
}
