namespace AG.Claims.Audatex
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.cieca.com/BMS", IsNullable = false)]
    public partial class AssignmentAddRs
    {

        private string rqUIDField;

        private ApplicationStatus applicationStatusField;

        /// <remarks/>
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
        public ApplicationStatus ApplicationStatus
        {
            get
            {
                return this.applicationStatusField;
            }
            set
            {
                this.applicationStatusField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class ApplicationStatus
    {

        private string applicationStatusCodeField;

        private ApplicationError applicationErrorField;

        /// <remarks/>
        public string ApplicationStatusCode
        {
            get
            {
                return this.applicationStatusCodeField;
            }
            set
            {
                this.applicationStatusCodeField = value;
            }
        }

        /// <remarks/>
        public ApplicationError ApplicationError
        {
            get
            {
                return this.applicationErrorField;
            }
            set
            {
                this.applicationErrorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class ApplicationError
    {

        private string errorCodeField;

        private string severityField;

        private string errorDescField;

        /// <remarks/>
        public string ErrorCode
        {
            get
            {
                return this.errorCodeField;
            }
            set
            {
                this.errorCodeField = value;
            }
        }

        /// <remarks/>
        public string Severity
        {
            get
            {
                return this.severityField;
            }
            set
            {
                this.severityField = value;
            }
        }

        /// <remarks/>
        public string ErrorDesc
        {
            get
            {
                return this.errorDescField;
            }
            set
            {
                this.errorDescField = value;
            }
        }
    }


}
