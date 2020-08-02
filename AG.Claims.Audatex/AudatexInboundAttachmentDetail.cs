using System.Runtime.Serialization;

namespace AG.Claims.Audatex
{
    [DataContract(Namespace = "")]
    class AudatexInboundAttachmentDetail
    {
        #region DataMembers
        [DataMember]
        public string ReqId { get; set; }
        [DataMember]
        public string ClaimNumber { get; set; }
        [DataMember]
        public string DocumentType { get; set; }
        [DataMember]
        public string DocumentFileType { get; set; }
        [DataMember]
        public byte[] DocumentContent { get; set; }
        [DataMember]
        public string DocumentFileName { get; set; }
        [DataMember]
        public int TotalDocs { get; set; }
        [DataMember]
        public int CurrentDoc { get; set; }
        [DataMember]
        public int FilenoteCreated { get; set; }
        #endregion
    }
}
