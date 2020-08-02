namespace AG.Claims.Audatex
{

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class AudatexB2BEstimateReturn
    {

        private int currentDocField;

        private int totalDocsField;

        private string claimNumField;

        private AttachmentAddRq attachmentAddRqField;
        private VehicleDamageEstimateAddRq vehicleDamageEstimateAddRqField;

        /// <remarks/>
        public int CurrentDoc
        {
            get
            {
                return this.currentDocField;
            }
            set
            {
                this.currentDocField = value;
            }
        }

        /// <remarks/>
        public int TotalDocs
        {
            get
            {
                return this.totalDocsField;
            }
            set
            {
                this.totalDocsField = value;
            }
        }

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

        /// <remarks/>
        public AttachmentAddRq AttachmentAddRq
        {
            get
            {
                return this.attachmentAddRqField;
            }
            set
            {
                this.attachmentAddRqField = value;
            }
        }
        public VehicleDamageEstimateAddRq VehicleDamageEstimateAddRq
        {
            get
            {
                return this.vehicleDamageEstimateAddRqField;
            }
            set
            {
                this.vehicleDamageEstimateAddRqField = value;
            }
        }
    }
}
