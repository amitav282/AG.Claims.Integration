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

        private uint partnerKeyField;

        private ushort svcProviderNameField;

        private DocumentInfo documentInfoField;

        private AttachmentAddRqAdminInfo adminInfoField;

        private ClaimInfo claimInfoField;

        private AttachmentAddRqVehicleInfo vehicleInfoField;

        public DocAttachment docAttachmentField;

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
        public uint PartnerKey
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
        public ushort SvcProviderName
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
        public AttachmentAddRqAdminInfo AdminInfo
        {
            get
            {
                return this.adminInfoField;
            }
            set
            {
                this.adminInfoField = value;
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
        public AttachmentAddRqVehicleInfo VehicleInfo
        {
            get
            {
                return this.vehicleInfoField;
            }
            set
            {
                this.vehicleInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.cieca.com/BMS")]
        public DocAttachment DocAttachment
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

        private string documentTypeField;

        private uint documentIDField;

        private string vendorCodeField;

        private DocumentInfoDocumentVer documentVerField;

        private string documentStatusField;

        private System.DateTime createDateTimeField;

        private System.DateTime transmitDateTimeField;

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
        public string DocumentType
        {
            get
            {
                return this.documentTypeField;
            }
            set
            {
                this.documentTypeField = value;
            }
        }

        /// <remarks/>
        public uint DocumentID
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
        public string VendorCode
        {
            get
            {
                return this.vendorCodeField;
            }
            set
            {
                this.vendorCodeField = value;
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
        public System.DateTime TransmitDateTime
        {
            get
            {
                return this.transmitDateTimeField;
            }
            set
            {
                this.transmitDateTimeField = value;
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

        private DocumentInfoReferenceInfoOtherReferenceInfo[] otherReferenceInfoField;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherReferenceInfo")]
        public DocumentInfoReferenceInfoOtherReferenceInfo[] OtherReferenceInfo
        {
            get
            {
                return this.otherReferenceInfoField;
            }
            set
            {
                this.otherReferenceInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class DocumentInfoReferenceInfoInternalGroupInfo
    {

        private uint internalGroupIDField;

        private uint internalGroupItemIDField;

        /// <remarks/>
        public uint InternalGroupID
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
        public uint InternalGroupItemID
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
    public partial class DocumentInfoReferenceInfoOtherReferenceInfo
    {

        private string otherReferenceNameField;

        private string otherRefNumField;

        /// <remarks/>
        public string OtherReferenceName
        {
            get
            {
                return this.otherReferenceNameField;
            }
            set
            {
                this.otherReferenceNameField = value;
            }
        }

        /// <remarks/>
        public string OtherRefNum
        {
            get
            {
                return this.otherRefNumField;
            }
            set
            {
                this.otherRefNumField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfo
    {

        private AttachmentAddRqAdminInfoInsuranceCompany insuranceCompanyField;

        private AttachmentAddRqAdminInfoClaimOffice claimOfficeField;

        private AttachmentAddRqAdminInfoPolicyHolder policyHolderField;

        private AttachmentAddRqAdminInfoOwner ownerField;

        private AttachmentAddRqAdminInfoEstimator estimatorField;

        private AttachmentAddRqAdminInfoAdjuster adjusterField;

        private AttachmentAddRqAdminInfoSupplier[] supplierField;

        private AttachmentAddRqAdminInfoSender senderField;

        /// <remarks/>
        public AttachmentAddRqAdminInfoInsuranceCompany InsuranceCompany
        {
            get
            {
                return this.insuranceCompanyField;
            }
            set
            {
                this.insuranceCompanyField = value;
            }
        }

        /// <remarks/>
        public AttachmentAddRqAdminInfoClaimOffice ClaimOffice
        {
            get
            {
                return this.claimOfficeField;
            }
            set
            {
                this.claimOfficeField = value;
            }
        }

        /// <remarks/>
        public AttachmentAddRqAdminInfoPolicyHolder PolicyHolder
        {
            get
            {
                return this.policyHolderField;
            }
            set
            {
                this.policyHolderField = value;
            }
        }

        /// <remarks/>
        public AttachmentAddRqAdminInfoOwner Owner
        {
            get
            {
                return this.ownerField;
            }
            set
            {
                this.ownerField = value;
            }
        }

        /// <remarks/>
        public AttachmentAddRqAdminInfoEstimator Estimator
        {
            get
            {
                return this.estimatorField;
            }
            set
            {
                this.estimatorField = value;
            }
        }

        /// <remarks/>
        public AttachmentAddRqAdminInfoAdjuster Adjuster
        {
            get
            {
                return this.adjusterField;
            }
            set
            {
                this.adjusterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Supplier")]
        public AttachmentAddRqAdminInfoSupplier[] Supplier
        {
            get
            {
                return this.supplierField;
            }
            set
            {
                this.supplierField = value;
            }
        }

        /// <remarks/>
        public AttachmentAddRqAdminInfoSender Sender
        {
            get
            {
                return this.senderField;
            }
            set
            {
                this.senderField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoInsuranceCompany
    {

        private AttachmentAddRqAdminInfoInsuranceCompanyParty partyField;

        /// <remarks/>
        public AttachmentAddRqAdminInfoInsuranceCompanyParty Party
        {
            get
            {
                return this.partyField;
            }
            set
            {
                this.partyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoInsuranceCompanyParty
    {

        private AttachmentAddRqAdminInfoInsuranceCompanyPartyOrgInfo orgInfoField;

        /// <remarks/>
        public AttachmentAddRqAdminInfoInsuranceCompanyPartyOrgInfo OrgInfo
        {
            get
            {
                return this.orgInfoField;
            }
            set
            {
                this.orgInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoInsuranceCompanyPartyOrgInfo
    {

        private string companyNameField;

        private AttachmentAddRqAdminInfoInsuranceCompanyPartyOrgInfoCommunications communicationsField;

        /// <remarks/>
        public string CompanyName
        {
            get
            {
                return this.companyNameField;
            }
            set
            {
                this.companyNameField = value;
            }
        }

        /// <remarks/>
        public AttachmentAddRqAdminInfoInsuranceCompanyPartyOrgInfoCommunications Communications
        {
            get
            {
                return this.communicationsField;
            }
            set
            {
                this.communicationsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoInsuranceCompanyPartyOrgInfoCommunications
    {

        private string commQualifierField;

        private AttachmentAddRqAdminInfoInsuranceCompanyPartyOrgInfoCommunicationsAddress addressField;

        /// <remarks/>
        public string CommQualifier
        {
            get
            {
                return this.commQualifierField;
            }
            set
            {
                this.commQualifierField = value;
            }
        }

        /// <remarks/>
        public AttachmentAddRqAdminInfoInsuranceCompanyPartyOrgInfoCommunicationsAddress Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoInsuranceCompanyPartyOrgInfoCommunicationsAddress
    {

        private string countryCodeField;

        /// <remarks/>
        public string CountryCode
        {
            get
            {
                return this.countryCodeField;
            }
            set
            {
                this.countryCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoClaimOffice
    {

        private AttachmentAddRqAdminInfoClaimOfficeParty partyField;

        /// <remarks/>
        public AttachmentAddRqAdminInfoClaimOfficeParty Party
        {
            get
            {
                return this.partyField;
            }
            set
            {
                this.partyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoClaimOfficeParty
    {

        private AttachmentAddRqAdminInfoClaimOfficePartyPersonInfo personInfoField;

        /// <remarks/>
        public AttachmentAddRqAdminInfoClaimOfficePartyPersonInfo PersonInfo
        {
            get
            {
                return this.personInfoField;
            }
            set
            {
                this.personInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoClaimOfficePartyPersonInfo
    {

        private AttachmentAddRqAdminInfoClaimOfficePartyPersonInfoPersonName personNameField;

        private AttachmentAddRqAdminInfoClaimOfficePartyPersonInfoCommunications communicationsField;

        /// <remarks/>
        public AttachmentAddRqAdminInfoClaimOfficePartyPersonInfoPersonName PersonName
        {
            get
            {
                return this.personNameField;
            }
            set
            {
                this.personNameField = value;
            }
        }

        /// <remarks/>
        public AttachmentAddRqAdminInfoClaimOfficePartyPersonInfoCommunications Communications
        {
            get
            {
                return this.communicationsField;
            }
            set
            {
                this.communicationsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoClaimOfficePartyPersonInfoPersonName
    {

        private string firstNameField;

        private string lastNameField;

        /// <remarks/>
        public string FirstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }

        /// <remarks/>
        public string LastName
        {
            get
            {
                return this.lastNameField;
            }
            set
            {
                this.lastNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoClaimOfficePartyPersonInfoCommunications
    {

        private string commQualifierField;

        private AttachmentAddRqAdminInfoClaimOfficePartyPersonInfoCommunicationsAddress addressField;

        /// <remarks/>
        public string CommQualifier
        {
            get
            {
                return this.commQualifierField;
            }
            set
            {
                this.commQualifierField = value;
            }
        }

        /// <remarks/>
        public AttachmentAddRqAdminInfoClaimOfficePartyPersonInfoCommunicationsAddress Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoClaimOfficePartyPersonInfoCommunicationsAddress
    {

        private string countryCodeField;

        /// <remarks/>
        public string CountryCode
        {
            get
            {
                return this.countryCodeField;
            }
            set
            {
                this.countryCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoPolicyHolder
    {

        private AttachmentAddRqAdminInfoPolicyHolderParty partyField;

        /// <remarks/>
        public AttachmentAddRqAdminInfoPolicyHolderParty Party
        {
            get
            {
                return this.partyField;
            }
            set
            {
                this.partyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoPolicyHolderParty
    {

        private AttachmentAddRqAdminInfoPolicyHolderPartyPersonInfo personInfoField;

        /// <remarks/>
        public AttachmentAddRqAdminInfoPolicyHolderPartyPersonInfo PersonInfo
        {
            get
            {
                return this.personInfoField;
            }
            set
            {
                this.personInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoPolicyHolderPartyPersonInfo
    {

        private AttachmentAddRqAdminInfoPolicyHolderPartyPersonInfoPersonName personNameField;

        private AttachmentAddRqAdminInfoPolicyHolderPartyPersonInfoCommunications[] communicationsField;

        /// <remarks/>
        public AttachmentAddRqAdminInfoPolicyHolderPartyPersonInfoPersonName PersonName
        {
            get
            {
                return this.personNameField;
            }
            set
            {
                this.personNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Communications")]
        public AttachmentAddRqAdminInfoPolicyHolderPartyPersonInfoCommunications[] Communications
        {
            get
            {
                return this.communicationsField;
            }
            set
            {
                this.communicationsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoPolicyHolderPartyPersonInfoPersonName
    {

        private string firstNameField;

        private string lastNameField;

        /// <remarks/>
        public string FirstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }

        /// <remarks/>
        public string LastName
        {
            get
            {
                return this.lastNameField;
            }
            set
            {
                this.lastNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoPolicyHolderPartyPersonInfoCommunications
    {

        private string commQualifierField;

        private AttachmentAddRqAdminInfoPolicyHolderPartyPersonInfoCommunicationsAddress addressField;

        private string commPhoneField;

        /// <remarks/>
        public string CommQualifier
        {
            get
            {
                return this.commQualifierField;
            }
            set
            {
                this.commQualifierField = value;
            }
        }

        /// <remarks/>
        public AttachmentAddRqAdminInfoPolicyHolderPartyPersonInfoCommunicationsAddress Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        public string CommPhone
        {
            get
            {
                return this.commPhoneField;
            }
            set
            {
                this.commPhoneField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoPolicyHolderPartyPersonInfoCommunicationsAddress
    {

        private string countryCodeField;

        /// <remarks/>
        public string CountryCode
        {
            get
            {
                return this.countryCodeField;
            }
            set
            {
                this.countryCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoOwner
    {

        private AttachmentAddRqAdminInfoOwnerParty partyField;

        /// <remarks/>
        public AttachmentAddRqAdminInfoOwnerParty Party
        {
            get
            {
                return this.partyField;
            }
            set
            {
                this.partyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoOwnerParty
    {

        private AttachmentAddRqAdminInfoOwnerPartyPersonInfo personInfoField;

        /// <remarks/>
        public AttachmentAddRqAdminInfoOwnerPartyPersonInfo PersonInfo
        {
            get
            {
                return this.personInfoField;
            }
            set
            {
                this.personInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoOwnerPartyPersonInfo
    {

        private AttachmentAddRqAdminInfoOwnerPartyPersonInfoPersonName personNameField;

        private AttachmentAddRqAdminInfoOwnerPartyPersonInfoCommunications[] communicationsField;

        /// <remarks/>
        public AttachmentAddRqAdminInfoOwnerPartyPersonInfoPersonName PersonName
        {
            get
            {
                return this.personNameField;
            }
            set
            {
                this.personNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Communications")]
        public AttachmentAddRqAdminInfoOwnerPartyPersonInfoCommunications[] Communications
        {
            get
            {
                return this.communicationsField;
            }
            set
            {
                this.communicationsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoOwnerPartyPersonInfoPersonName
    {

        private string firstNameField;

        private string lastNameField;

        /// <remarks/>
        public string FirstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }

        /// <remarks/>
        public string LastName
        {
            get
            {
                return this.lastNameField;
            }
            set
            {
                this.lastNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoOwnerPartyPersonInfoCommunications
    {

        private string commQualifierField;

        private AttachmentAddRqAdminInfoOwnerPartyPersonInfoCommunicationsAddress addressField;

        private string commPhoneField;

        /// <remarks/>
        public string CommQualifier
        {
            get
            {
                return this.commQualifierField;
            }
            set
            {
                this.commQualifierField = value;
            }
        }

        /// <remarks/>
        public AttachmentAddRqAdminInfoOwnerPartyPersonInfoCommunicationsAddress Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        public string CommPhone
        {
            get
            {
                return this.commPhoneField;
            }
            set
            {
                this.commPhoneField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoOwnerPartyPersonInfoCommunicationsAddress
    {

        private string address1Field;

        private string cityField;

        private string stateProvinceField;

        private string postalCodeField;

        private string countryCodeField;

        /// <remarks/>
        public string Address1
        {
            get
            {
                return this.address1Field;
            }
            set
            {
                this.address1Field = value;
            }
        }

        /// <remarks/>
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public string StateProvince
        {
            get
            {
                return this.stateProvinceField;
            }
            set
            {
                this.stateProvinceField = value;
            }
        }

        /// <remarks/>
        public string PostalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }

        /// <remarks/>
        public string CountryCode
        {
            get
            {
                return this.countryCodeField;
            }
            set
            {
                this.countryCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoEstimator
    {

        private AttachmentAddRqAdminInfoEstimatorParty partyField;

        private string affiliationField;

        /// <remarks/>
        public AttachmentAddRqAdminInfoEstimatorParty Party
        {
            get
            {
                return this.partyField;
            }
            set
            {
                this.partyField = value;
            }
        }

        /// <remarks/>
        public string Affiliation
        {
            get
            {
                return this.affiliationField;
            }
            set
            {
                this.affiliationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoEstimatorParty
    {

        private AttachmentAddRqAdminInfoEstimatorPartyPersonInfo personInfoField;

        /// <remarks/>
        public AttachmentAddRqAdminInfoEstimatorPartyPersonInfo PersonInfo
        {
            get
            {
                return this.personInfoField;
            }
            set
            {
                this.personInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoEstimatorPartyPersonInfo
    {

        private AttachmentAddRqAdminInfoEstimatorPartyPersonInfoPersonName personNameField;

        private AttachmentAddRqAdminInfoEstimatorPartyPersonInfoCommunications communicationsField;

        /// <remarks/>
        public AttachmentAddRqAdminInfoEstimatorPartyPersonInfoPersonName PersonName
        {
            get
            {
                return this.personNameField;
            }
            set
            {
                this.personNameField = value;
            }
        }

        /// <remarks/>
        public AttachmentAddRqAdminInfoEstimatorPartyPersonInfoCommunications Communications
        {
            get
            {
                return this.communicationsField;
            }
            set
            {
                this.communicationsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoEstimatorPartyPersonInfoPersonName
    {

        private string lastNameField;

        /// <remarks/>
        public string LastName
        {
            get
            {
                return this.lastNameField;
            }
            set
            {
                this.lastNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoEstimatorPartyPersonInfoCommunications
    {

        private string commQualifierField;

        private AttachmentAddRqAdminInfoEstimatorPartyPersonInfoCommunicationsAddress addressField;

        /// <remarks/>
        public string CommQualifier
        {
            get
            {
                return this.commQualifierField;
            }
            set
            {
                this.commQualifierField = value;
            }
        }

        /// <remarks/>
        public AttachmentAddRqAdminInfoEstimatorPartyPersonInfoCommunicationsAddress Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoEstimatorPartyPersonInfoCommunicationsAddress
    {

        private string countryCodeField;

        /// <remarks/>
        public string CountryCode
        {
            get
            {
                return this.countryCodeField;
            }
            set
            {
                this.countryCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoAdjuster
    {

        private AttachmentAddRqAdminInfoAdjusterParty partyField;

        private string affiliationField;

        /// <remarks/>
        public AttachmentAddRqAdminInfoAdjusterParty Party
        {
            get
            {
                return this.partyField;
            }
            set
            {
                this.partyField = value;
            }
        }

        /// <remarks/>
        public string Affiliation
        {
            get
            {
                return this.affiliationField;
            }
            set
            {
                this.affiliationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoAdjusterParty
    {

        private AttachmentAddRqAdminInfoAdjusterPartyPersonInfo personInfoField;

        /// <remarks/>
        public AttachmentAddRqAdminInfoAdjusterPartyPersonInfo PersonInfo
        {
            get
            {
                return this.personInfoField;
            }
            set
            {
                this.personInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoAdjusterPartyPersonInfo
    {

        private AttachmentAddRqAdminInfoAdjusterPartyPersonInfoPersonName personNameField;

        private AttachmentAddRqAdminInfoAdjusterPartyPersonInfoCommunications communicationsField;

        /// <remarks/>
        public AttachmentAddRqAdminInfoAdjusterPartyPersonInfoPersonName PersonName
        {
            get
            {
                return this.personNameField;
            }
            set
            {
                this.personNameField = value;
            }
        }

        /// <remarks/>
        public AttachmentAddRqAdminInfoAdjusterPartyPersonInfoCommunications Communications
        {
            get
            {
                return this.communicationsField;
            }
            set
            {
                this.communicationsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoAdjusterPartyPersonInfoPersonName
    {

        private string firstNameField;

        private string lastNameField;

        /// <remarks/>
        public string FirstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }

        /// <remarks/>
        public string LastName
        {
            get
            {
                return this.lastNameField;
            }
            set
            {
                this.lastNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoAdjusterPartyPersonInfoCommunications
    {

        private string commQualifierField;

        private AttachmentAddRqAdminInfoAdjusterPartyPersonInfoCommunicationsAddress addressField;

        /// <remarks/>
        public string CommQualifier
        {
            get
            {
                return this.commQualifierField;
            }
            set
            {
                this.commQualifierField = value;
            }
        }

        /// <remarks/>
        public AttachmentAddRqAdminInfoAdjusterPartyPersonInfoCommunicationsAddress Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoAdjusterPartyPersonInfoCommunicationsAddress
    {

        private string countryCodeField;

        /// <remarks/>
        public string CountryCode
        {
            get
            {
                return this.countryCodeField;
            }
            set
            {
                this.countryCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoSupplier
    {

        private AttachmentAddRqAdminInfoSupplierParty partyField;

        /// <remarks/>
        public AttachmentAddRqAdminInfoSupplierParty Party
        {
            get
            {
                return this.partyField;
            }
            set
            {
                this.partyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoSupplierParty
    {

        private AttachmentAddRqAdminInfoSupplierPartyOrgInfo orgInfoField;

        private AttachmentAddRqAdminInfoSupplierPartyCommunications[] contactInfoField;

        /// <remarks/>
        public AttachmentAddRqAdminInfoSupplierPartyOrgInfo OrgInfo
        {
            get
            {
                return this.orgInfoField;
            }
            set
            {
                this.orgInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Communications", IsNullable = false)]
        public AttachmentAddRqAdminInfoSupplierPartyCommunications[] ContactInfo
        {
            get
            {
                return this.contactInfoField;
            }
            set
            {
                this.contactInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoSupplierPartyOrgInfo
    {

        private string companyNameField;

        private AttachmentAddRqAdminInfoSupplierPartyOrgInfoIDInfo iDInfoField;

        private AttachmentAddRqAdminInfoSupplierPartyOrgInfoCommunications communicationsField;

        /// <remarks/>
        public string CompanyName
        {
            get
            {
                return this.companyNameField;
            }
            set
            {
                this.companyNameField = value;
            }
        }

        /// <remarks/>
        public AttachmentAddRqAdminInfoSupplierPartyOrgInfoIDInfo IDInfo
        {
            get
            {
                return this.iDInfoField;
            }
            set
            {
                this.iDInfoField = value;
            }
        }

        /// <remarks/>
        public AttachmentAddRqAdminInfoSupplierPartyOrgInfoCommunications Communications
        {
            get
            {
                return this.communicationsField;
            }
            set
            {
                this.communicationsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoSupplierPartyOrgInfoIDInfo
    {

        private string iDQualifierCodeField;

        private string iDNumField;

        /// <remarks/>
        public string IDQualifierCode
        {
            get
            {
                return this.iDQualifierCodeField;
            }
            set
            {
                this.iDQualifierCodeField = value;
            }
        }

        /// <remarks/>
        public string IDNum
        {
            get
            {
                return this.iDNumField;
            }
            set
            {
                this.iDNumField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoSupplierPartyOrgInfoCommunications
    {

        private string commQualifierField;

        private AttachmentAddRqAdminInfoSupplierPartyOrgInfoCommunicationsAddress addressField;

        /// <remarks/>
        public string CommQualifier
        {
            get
            {
                return this.commQualifierField;
            }
            set
            {
                this.commQualifierField = value;
            }
        }

        /// <remarks/>
        public AttachmentAddRqAdminInfoSupplierPartyOrgInfoCommunicationsAddress Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoSupplierPartyOrgInfoCommunicationsAddress
    {

        private string address1Field;

        private string cityField;

        private string stateProvinceField;

        private uint postalCodeField;

        /// <remarks/>
        public string Address1
        {
            get
            {
                return this.address1Field;
            }
            set
            {
                this.address1Field = value;
            }
        }

        /// <remarks/>
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public string StateProvince
        {
            get
            {
                return this.stateProvinceField;
            }
            set
            {
                this.stateProvinceField = value;
            }
        }

        /// <remarks/>
        public uint PostalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoSupplierPartyCommunications
    {

        private string commQualifierField;

        private string commPhoneField;

        /// <remarks/>
        public string CommQualifier
        {
            get
            {
                return this.commQualifierField;
            }
            set
            {
                this.commQualifierField = value;
            }
        }

        /// <remarks/>
        public string CommPhone
        {
            get
            {
                return this.commPhoneField;
            }
            set
            {
                this.commPhoneField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoSender
    {

        private AttachmentAddRqAdminInfoSenderParty partyField;

        /// <remarks/>
        public AttachmentAddRqAdminInfoSenderParty Party
        {
            get
            {
                return this.partyField;
            }
            set
            {
                this.partyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoSenderParty
    {

        private AttachmentAddRqAdminInfoSenderPartyOrgInfo orgInfoField;

        /// <remarks/>
        public AttachmentAddRqAdminInfoSenderPartyOrgInfo OrgInfo
        {
            get
            {
                return this.orgInfoField;
            }
            set
            {
                this.orgInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoSenderPartyOrgInfo
    {

        private string companyNameField;

        private AttachmentAddRqAdminInfoSenderPartyOrgInfoIDInfo iDInfoField;

        /// <remarks/>
        public string CompanyName
        {
            get
            {
                return this.companyNameField;
            }
            set
            {
                this.companyNameField = value;
            }
        }

        /// <remarks/>
        public AttachmentAddRqAdminInfoSenderPartyOrgInfoIDInfo IDInfo
        {
            get
            {
                return this.iDInfoField;
            }
            set
            {
                this.iDInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqAdminInfoSenderPartyOrgInfoIDInfo
    {

        private string iDQualifierCodeField;

        private uint iDNumField;

        /// <remarks/>
        public string IDQualifierCode
        {
            get
            {
                return this.iDQualifierCodeField;
            }
            set
            {
                this.iDQualifierCodeField = value;
            }
        }

        /// <remarks/>
        public uint IDNum
        {
            get
            {
                return this.iDNumField;
            }
            set
            {
                this.iDNumField = value;
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

        private ClaimInfoPolicyInfo policyInfoField;

        private ClaimInfoLossInfo lossInfoField;

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
        public ClaimInfoPolicyInfo PolicyInfo
        {
            get
            {
                return this.policyInfoField;
            }
            set
            {
                this.policyInfoField = value;
            }
        }

        /// <remarks/>
        public ClaimInfoLossInfo LossInfo
        {
            get
            {
                return this.lossInfoField;
            }
            set
            {
                this.lossInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class ClaimInfoPolicyInfo
    {

        private uint policyNumField;

        private ClaimInfoPolicyInfoCoverageInfo coverageInfoField;

        /// <remarks/>
        public uint PolicyNum
        {
            get
            {
                return this.policyNumField;
            }
            set
            {
                this.policyNumField = value;
            }
        }

        /// <remarks/>
        public ClaimInfoPolicyInfoCoverageInfo CoverageInfo
        {
            get
            {
                return this.coverageInfoField;
            }
            set
            {
                this.coverageInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class ClaimInfoPolicyInfoCoverageInfo
    {

        private ClaimInfoPolicyInfoCoverageInfoCoverage coverageField;

        /// <remarks/>
        public ClaimInfoPolicyInfoCoverageInfoCoverage Coverage
        {
            get
            {
                return this.coverageField;
            }
            set
            {
                this.coverageField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class ClaimInfoPolicyInfoCoverageInfoCoverage
    {

        private string coverageCategoryField;

        private ClaimInfoPolicyInfoCoverageInfoCoverageDeductibleInfo deductibleInfoField;

        /// <remarks/>
        public string CoverageCategory
        {
            get
            {
                return this.coverageCategoryField;
            }
            set
            {
                this.coverageCategoryField = value;
            }
        }

        /// <remarks/>
        public ClaimInfoPolicyInfoCoverageInfoCoverageDeductibleInfo DeductibleInfo
        {
            get
            {
                return this.deductibleInfoField;
            }
            set
            {
                this.deductibleInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class ClaimInfoPolicyInfoCoverageInfoCoverageDeductibleInfo
    {

        private string deductibleStatusField;

        private decimal deductibleAmtField;

        /// <remarks/>
        public string DeductibleStatus
        {
            get
            {
                return this.deductibleStatusField;
            }
            set
            {
                this.deductibleStatusField = value;
            }
        }

        /// <remarks/>
        public decimal DeductibleAmt
        {
            get
            {
                return this.deductibleAmtField;
            }
            set
            {
                this.deductibleAmtField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class ClaimInfoLossInfo
    {

        private ClaimInfoLossInfoFacts factsField;

        private ClaimInfoLossInfoInspection inspectionField;

        private string totalLossIndField;

        /// <remarks/>
        public ClaimInfoLossInfoFacts Facts
        {
            get
            {
                return this.factsField;
            }
            set
            {
                this.factsField = value;
            }
        }

        /// <remarks/>
        public ClaimInfoLossInfoInspection Inspection
        {
            get
            {
                return this.inspectionField;
            }
            set
            {
                this.inspectionField = value;
            }
        }

        /// <remarks/>
        public string TotalLossInd
        {
            get
            {
                return this.totalLossIndField;
            }
            set
            {
                this.totalLossIndField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class ClaimInfoLossInfoFacts
    {

        private System.DateTime lossDateTimeField;

        private byte theftIndField;

        private ClaimInfoLossInfoFactsPrimaryPOI primaryPOIField;

        /// <remarks/>
        public System.DateTime LossDateTime
        {
            get
            {
                return this.lossDateTimeField;
            }
            set
            {
                this.lossDateTimeField = value;
            }
        }

        /// <remarks/>
        public byte TheftInd
        {
            get
            {
                return this.theftIndField;
            }
            set
            {
                this.theftIndField = value;
            }
        }

        /// <remarks/>
        public ClaimInfoLossInfoFactsPrimaryPOI PrimaryPOI
        {
            get
            {
                return this.primaryPOIField;
            }
            set
            {
                this.primaryPOIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class ClaimInfoLossInfoFactsPrimaryPOI
    {

        private byte pOICodeField;

        /// <remarks/>
        public byte POICode
        {
            get
            {
                return this.pOICodeField;
            }
            set
            {
                this.pOICodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class ClaimInfoLossInfoInspection
    {

        private string inspectionSiteCodeField;

        /// <remarks/>
        public string InspectionSiteCode
        {
            get
            {
                return this.inspectionSiteCodeField;
            }
            set
            {
                this.inspectionSiteCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqVehicleInfo
    {

        private AttachmentAddRqVehicleInfoVINInfo vINInfoField;

        private AttachmentAddRqVehicleInfoVehicleDesc vehicleDescField;

        private AttachmentAddRqVehicleInfoPowertrain powertrainField;

        private AttachmentAddRqVehicleInfoCondition conditionField;

        private string vehicleMemoField;

        /// <remarks/>
        public AttachmentAddRqVehicleInfoVINInfo VINInfo
        {
            get
            {
                return this.vINInfoField;
            }
            set
            {
                this.vINInfoField = value;
            }
        }

        /// <remarks/>
        public AttachmentAddRqVehicleInfoVehicleDesc VehicleDesc
        {
            get
            {
                return this.vehicleDescField;
            }
            set
            {
                this.vehicleDescField = value;
            }
        }

        /// <remarks/>
        public AttachmentAddRqVehicleInfoPowertrain Powertrain
        {
            get
            {
                return this.powertrainField;
            }
            set
            {
                this.powertrainField = value;
            }
        }

        /// <remarks/>
        public AttachmentAddRqVehicleInfoCondition Condition
        {
            get
            {
                return this.conditionField;
            }
            set
            {
                this.conditionField = value;
            }
        }

        /// <remarks/>
        public string VehicleMemo
        {
            get
            {
                return this.vehicleMemoField;
            }
            set
            {
                this.vehicleMemoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqVehicleInfoVINInfo
    {

        private string vINAvailabilityCodeField;

        /// <remarks/>
        public string VINAvailabilityCode
        {
            get
            {
                return this.vINAvailabilityCodeField;
            }
            set
            {
                this.vINAvailabilityCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqVehicleInfoVehicleDesc
    {

        private ushort modelYearField;

        private string makeDescField;

        private string modelNameField;

        private AttachmentAddRqVehicleInfoVehicleDescOdometerInfo odometerInfoField;

        private AttachmentAddRqVehicleInfoVehicleDescOption[] vehicleOptionsField;

        private string databaseCodeField;

        private string vehicleDescMemoField;

        private AttachmentAddRqVehicleInfoVehicleDescNICBInfo nICBInfoField;

        /// <remarks/>
        public ushort ModelYear
        {
            get
            {
                return this.modelYearField;
            }
            set
            {
                this.modelYearField = value;
            }
        }

        /// <remarks/>
        public string MakeDesc
        {
            get
            {
                return this.makeDescField;
            }
            set
            {
                this.makeDescField = value;
            }
        }

        /// <remarks/>
        public string ModelName
        {
            get
            {
                return this.modelNameField;
            }
            set
            {
                this.modelNameField = value;
            }
        }

        /// <remarks/>
        public AttachmentAddRqVehicleInfoVehicleDescOdometerInfo OdometerInfo
        {
            get
            {
                return this.odometerInfoField;
            }
            set
            {
                this.odometerInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Option", IsNullable = false)]
        public AttachmentAddRqVehicleInfoVehicleDescOption[] VehicleOptions
        {
            get
            {
                return this.vehicleOptionsField;
            }
            set
            {
                this.vehicleOptionsField = value;
            }
        }

        /// <remarks/>
        public string DatabaseCode
        {
            get
            {
                return this.databaseCodeField;
            }
            set
            {
                this.databaseCodeField = value;
            }
        }

        /// <remarks/>
        public string VehicleDescMemo
        {
            get
            {
                return this.vehicleDescMemoField;
            }
            set
            {
                this.vehicleDescMemoField = value;
            }
        }

        /// <remarks/>
        public AttachmentAddRqVehicleInfoVehicleDescNICBInfo NICBInfo
        {
            get
            {
                return this.nICBInfoField;
            }
            set
            {
                this.nICBInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqVehicleInfoVehicleDescOdometerInfo
    {

        private byte odometerIndField;

        private ushort odometerReadingField;

        private string odometerReadingCodeField;

        /// <remarks/>
        public byte OdometerInd
        {
            get
            {
                return this.odometerIndField;
            }
            set
            {
                this.odometerIndField = value;
            }
        }

        /// <remarks/>
        public ushort OdometerReading
        {
            get
            {
                return this.odometerReadingField;
            }
            set
            {
                this.odometerReadingField = value;
            }
        }

        /// <remarks/>
        public string OdometerReadingCode
        {
            get
            {
                return this.odometerReadingCodeField;
            }
            set
            {
                this.odometerReadingCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqVehicleInfoVehicleDescOption
    {

        private string optionCodeField;

        private string optionDescField;

        /// <remarks/>
        public string OptionCode
        {
            get
            {
                return this.optionCodeField;
            }
            set
            {
                this.optionCodeField = value;
            }
        }

        /// <remarks/>
        public string OptionDesc
        {
            get
            {
                return this.optionDescField;
            }
            set
            {
                this.optionDescField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqVehicleInfoVehicleDescNICBInfo
    {

        private string nICBMakeField;

        private string nICBModelField;

        /// <remarks/>
        public string NICBMake
        {
            get
            {
                return this.nICBMakeField;
            }
            set
            {
                this.nICBMakeField = value;
            }
        }

        /// <remarks/>
        public string NICBModel
        {
            get
            {
                return this.nICBModelField;
            }
            set
            {
                this.nICBModelField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqVehicleInfoPowertrain
    {

        private byte engineNumField;

        private string engineDescField;

        private string engineCodeField;

        private AttachmentAddRqVehicleInfoPowertrainTransmissionInfo transmissionInfoField;

        /// <remarks/>
        public byte EngineNum
        {
            get
            {
                return this.engineNumField;
            }
            set
            {
                this.engineNumField = value;
            }
        }

        /// <remarks/>
        public string EngineDesc
        {
            get
            {
                return this.engineDescField;
            }
            set
            {
                this.engineDescField = value;
            }
        }

        /// <remarks/>
        public string EngineCode
        {
            get
            {
                return this.engineCodeField;
            }
            set
            {
                this.engineCodeField = value;
            }
        }

        /// <remarks/>
        public AttachmentAddRqVehicleInfoPowertrainTransmissionInfo TransmissionInfo
        {
            get
            {
                return this.transmissionInfoField;
            }
            set
            {
                this.transmissionInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqVehicleInfoPowertrainTransmissionInfo
    {

        private string transmissionCodeField;

        private string transmissionDescField;

        /// <remarks/>
        public string TransmissionCode
        {
            get
            {
                return this.transmissionCodeField;
            }
            set
            {
                this.transmissionCodeField = value;
            }
        }

        /// <remarks/>
        public string TransmissionDesc
        {
            get
            {
                return this.transmissionDescField;
            }
            set
            {
                this.transmissionDescField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AttachmentAddRqVehicleInfoCondition
    {

        private string drivableIndField;

        private string priorDamageIndField;

        /// <remarks/>
        public string DrivableInd
        {
            get
            {
                return this.drivableIndField;
            }
            set
            {
                this.drivableIndField = value;
            }
        }

        /// <remarks/>
        public string PriorDamageInd
        {
            get
            {
                return this.priorDamageIndField;
            }
            set
            {
                this.priorDamageIndField = value;
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

        private string attachmentURIField;

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
        public string AttachmentURI
        {
            get
            {
                return this.attachmentURIField;
            }
            set
            {
                this.attachmentURIField = value;
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
