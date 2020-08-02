namespace AG.Claims.LXNX
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cp.com/rules/client")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://cp.com/rules/client", IsNullable = false, ElementName = "result")]
    public partial class Result
    {

        private Message[] messagesField;
        private ProductResults productresultsField;
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem("message", IsNullable = false)]
        public Message[] messages
        {
            get
            {
                return this.messagesField;
            }
            set
            {
                this.messagesField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("product_results", IsNullable = false)]
        public ProductResults ProductResults
        {
            get
            {
                return this.productresultsField;
            }
            set
            {
                this.productresultsField = value;
            }
        }

    }
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cp.com/rules/client", TypeName = "message")]
    public partial class Message
    {

        private string typeField;

        private string codeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "type")]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "code")]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cp.com/rules/client", TypeName = "product_results")]
    public partial class ProductResults
    {

        private ClaimsDataFill claimsdatafillField;

        [System.Xml.Serialization.XmlElement("claims_datafill", IsNullable = false)]
        public ClaimsDataFill ClaimsFill
        {
            get
            {
                return this.claimsdatafillField;
            }
            set
            {
                this.claimsdatafillField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cp.com/rules/client", TypeName = "claims_datafill")]
    public partial class ClaimsDataFill
    {

        private FormattedReport formattedreportField;
        [System.Xml.Serialization.XmlElement("formatted_report", IsNullable = false)]
        public FormattedReport FormatReport
        {
            get
            {
                return this.formattedreportField;
            }
            set
            {
                this.formattedreportField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cp.com/rules/client", TypeName = "formatted_report")]
    public partial class FormattedReport
    {

        private Report reportField;

        [System.Xml.Serialization.XmlElement(ElementName = "report")]
        public Report ReportField
        {
            get
            {
                return this.reportField;
            }
            set
            {
                this.reportField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cp.com/rules/client", TypeName = "report")]
    public partial class Report
    {

        private string formatField;

        private bool encodedField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "format")]
        public string Format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "encoded")]
        public bool Encoded
        {
            get
            {
                return this.encodedField;
            }
            set
            {
                this.encodedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

}


