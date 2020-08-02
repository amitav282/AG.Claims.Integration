namespace AG.Claims.Audatex
{

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class AttachmentAddRq
    {

        private string rqUIDField;

        private string partnerKeyField;

        private string svcProviderNameField;

        private DocumentInfo documentInfoField;

        private ClaimInfo claimInfoField;

        private DocAttachment[] docAttachmentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.cieca.com/BMS")]
        public string RqUID
        {
            get
            {
                return this.rqUIDField;
            }
            set
            {
                this.rqUIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.cieca.com/BMS")]
        public string PartnerKey
        {
            get
            {
                return this.partnerKeyField;
            }
            set
            {
                this.partnerKeyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.cieca.com/BMS")]
        public string SvcProviderName
        {
            get
            {
                return this.svcProviderNameField;
            }
            set
            {
                this.svcProviderNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.cieca.com/BMS")]
        public DocumentInfo DocumentInfo
        {
            get
            {
                return this.documentInfoField;
            }
            set
            {
                this.documentInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.cieca.com/BMS")]
        public ClaimInfo ClaimInfo
        {
            get
            {
                return this.claimInfoField;
            }
            set
            {
                this.claimInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocAttachment", Namespace = "http://www.cieca.com/BMS")]
        public DocAttachment[] DocAttachment
        {
            get
            {
                return this.docAttachmentField;
            }
            set
            {
                this.docAttachmentField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.cieca.com/BMS", IsNullable = false)]
    public partial class DocumentInfo
    {

        private string bMSVerField;

        private string documentIDField;

        private DocumentInfoDocumentVer documentVerField;

        private string documentStatusField;

        private System.DateTime createDateTimeField;

        private DocumentInfoReferenceInfo referenceInfoField;

        /// <remarks/>
        public string BMSVer
        {
            get
            {
                return this.bMSVerField;
            }
            set
            {
                this.bMSVerField = value;
            }
        }

        /// <remarks/>
        public string DocumentID
        {
            get
            {
                return this.documentIDField;
            }
            set
            {
                this.documentIDField = value;
            }
        }

        /// <remarks/>
        public DocumentInfoDocumentVer DocumentVer
        {
            get
            {
                return this.documentVerField;
            }
            set
            {
                this.documentVerField = value;
            }
        }

        /// <remarks/>
        public string DocumentStatus
        {
            get
            {
                return this.documentStatusField;
            }
            set
            {
                this.documentStatusField = value;
            }
        }

        /// <remarks/>
        public System.DateTime CreateDateTime
        {
            get
            {
                return this.createDateTimeField;
            }
            set
            {
                this.createDateTimeField = value;
            }
        }

        /// <remarks/>
        public DocumentInfoReferenceInfo ReferenceInfo
        {
            get
            {
                return this.referenceInfoField;
            }
            set
            {
                this.referenceInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class DocumentInfoDocumentVer
    {

        private string documentVerCodeField;

        private byte documentVerNumField;

        /// <remarks/>
        public string DocumentVerCode
        {
            get
            {
                return this.documentVerCodeField;
            }
            set
            {
                this.documentVerCodeField = value;
            }
        }

        /// <remarks/>
        public byte DocumentVerNum
        {
            get
            {
                return this.documentVerNumField;
            }
            set
            {
                this.documentVerNumField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class DocumentInfoReferenceInfo
    {

        private DocumentInfoReferenceInfoInternalGroupInfo internalGroupInfoField;

        /// <remarks/>
        public DocumentInfoReferenceInfoInternalGroupInfo InternalGroupInfo
        {
            get
            {
                return this.internalGroupInfoField;
            }
            set
            {
                this.internalGroupInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class DocumentInfoReferenceInfoInternalGroupInfo
    {

        private string internalGroupIDField;

        private string internalGroupItemIDField;

        /// <remarks/>
        public string InternalGroupID
        {
            get
            {
                return this.internalGroupIDField;
            }
            set
            {
                this.internalGroupIDField = value;
            }
        }

        /// <remarks/>
        public string InternalGroupItemID
        {
            get
            {
                return this.internalGroupItemIDField;
            }
            set
            {
                this.internalGroupItemIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.cieca.com/BMS", IsNullable = false)]
    public partial class ClaimInfo
    {

        private string claimNumField;

        /// <remarks/>
        public string ClaimNum
        {
            get
            {
                return this.claimNumField;
            }
            set
            {
                this.claimNumField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.cieca.com/BMS", IsNullable = false)]
    public partial class DocAttachment
    {

        private string attachmentTypeField;

        private string attachmentMemoField;

        private string attachmentFileTypeField;

        private string attachmentFileNameField;

        private string attachmentLengthField;

        private DocAttachmentAttachmentIntegrity attachmentIntegrityField;

        /// <remarks/>
        public string AttachmentType
        {
            get
            {
                return this.attachmentTypeField;
            }
            set
            {
                this.attachmentTypeField = value;
            }
        }

        /// <remarks/>
        public string AttachmentMemo
        {
            get
            {
                return this.attachmentMemoField;
            }
            set
            {
                this.attachmentMemoField = value;
            }
        }

        /// <remarks/>
        public string AttachmentFileType
        {
            get
            {
                return this.attachmentFileTypeField;
            }
            set
            {
                this.attachmentFileTypeField = value;
            }
        }

        /// <remarks/>
        public string AttachmentFileName
        {
            get
            {
                return this.attachmentFileNameField;
            }
            set
            {
                this.attachmentFileNameField = value;
            }
        }

        /// <remarks/>
        public string AttachmentLength
        {
            get
            {
                return this.attachmentLengthField;
            }
            set
            {
                this.attachmentLengthField = value;
            }
        }

        /// <remarks/>
        public DocAttachmentAttachmentIntegrity AttachmentIntegrity
        {
            get
            {
                return this.attachmentIntegrityField;
            }
            set
            {
                this.attachmentIntegrityField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class DocAttachmentAttachmentIntegrity
    {

        private DocAttachmentAttachmentIntegrityIntegrityBinary integrityBinaryField;

        /// <remarks/>
        public DocAttachmentAttachmentIntegrityIntegrityBinary IntegrityBinary
        {
            get
            {
                return this.integrityBinaryField;
            }
            set
            {
                this.integrityBinaryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class DocAttachmentAttachmentIntegrityIntegrityBinary
    {

        private string embeddedAttachmentField;

        /// <remarks/>
        public string EmbeddedAttachment
        {
            get
            {
                return this.embeddedAttachmentField;
            }
            set
            {
                this.embeddedAttachmentField = value;
            }
        }
    }


}
