using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AG.Claims.Audatex
{

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.cieca.com/BMS", IsNullable = false)]
    public partial class VehicleDamageEstimateAddRq
    {

        private string rqUIDField;

        private string partnerKeyField;

        private ushort svcProviderNameField;

        private VehicleDamageEstimateAddRqDocumentInfo documentInfoField;

        private VehicleDamageEstimateAddRqApplicationInfo applicationInfoField;

        private VehicleDamageEstimateAddRqEventInfo eventInfoField;

        private VehicleDamageEstimateAddRqAdminInfo adminInfoField;

        private VehicleDamageEstimateAddRqEstimatorIDs estimatorIDsField;

        private VehicleDamageEstimateAddRqClaimInfo claimInfoField;

        private VehicleDamageEstimateAddRqVehicleInfo vehicleInfoField;

        private VehicleDamageEstimateAddRqProfileInfo profileInfoField;

        private VehicleDamageEstimateAddRqDamageLineInfo[] damageLineInfoField;

        private VehicleDamageEstimateAddRqRepairTotalsInfo repairTotalsInfoField;

        private string disclaimersField;

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
        public VehicleDamageEstimateAddRqDocumentInfo DocumentInfo
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
        public VehicleDamageEstimateAddRqApplicationInfo ApplicationInfo
        {
            get
            {
                return this.applicationInfoField;
            }
            set
            {
                this.applicationInfoField = value;
            }
        }

        /// <remarks/>
        public VehicleDamageEstimateAddRqEventInfo EventInfo
        {
            get
            {
                return this.eventInfoField;
            }
            set
            {
                this.eventInfoField = value;
            }
        }

        /// <remarks/>
        public VehicleDamageEstimateAddRqAdminInfo AdminInfo
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
        public VehicleDamageEstimateAddRqEstimatorIDs EstimatorIDs
        {
            get
            {
                return this.estimatorIDsField;
            }
            set
            {
                this.estimatorIDsField = value;
            }
        }

        /// <remarks/>
        public VehicleDamageEstimateAddRqClaimInfo ClaimInfo
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
        public VehicleDamageEstimateAddRqVehicleInfo VehicleInfo
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
        public VehicleDamageEstimateAddRqProfileInfo ProfileInfo
        {
            get
            {
                return this.profileInfoField;
            }
            set
            {
                this.profileInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DamageLineInfo")]
        public VehicleDamageEstimateAddRqDamageLineInfo[] DamageLineInfo
        {
            get
            {
                return this.damageLineInfoField;
            }
            set
            {
                this.damageLineInfoField = value;
            }
        }

        /// <remarks/>
        public VehicleDamageEstimateAddRqRepairTotalsInfo RepairTotalsInfo
        {
            get
            {
                return this.repairTotalsInfoField;
            }
            set
            {
                this.repairTotalsInfoField = value;
            }
        }

        /// <remarks/>
        public string Disclaimers
        {
            get
            {
                return this.disclaimersField;
            }
            set
            {
                this.disclaimersField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqDocumentInfo
    {

        private string bMSVerField;

        private string documentTypeField;

        private string documentIDField;

        private string vendorCodeField;

        private VehicleDamageEstimateAddRqDocumentInfoDocumentVer documentVerField;

        private string documentStatusField;

        private System.DateTime createDateTimeField;

        private System.DateTime transmitDateTimeField;

        private VehicleDamageEstimateAddRqDocumentInfoReferenceInfo referenceInfoField;

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
        public VehicleDamageEstimateAddRqDocumentInfoDocumentVer DocumentVer
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
        public VehicleDamageEstimateAddRqDocumentInfoReferenceInfo ReferenceInfo
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
    public partial class VehicleDamageEstimateAddRqDocumentInfoDocumentVer
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
    public partial class VehicleDamageEstimateAddRqDocumentInfoReferenceInfo
    {

        private VehicleDamageEstimateAddRqDocumentInfoReferenceInfoInternalGroupInfo internalGroupInfoField;

        /// <remarks/>
        public VehicleDamageEstimateAddRqDocumentInfoReferenceInfoInternalGroupInfo InternalGroupInfo
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
    public partial class VehicleDamageEstimateAddRqDocumentInfoReferenceInfoInternalGroupInfo
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
    public partial class VehicleDamageEstimateAddRqApplicationInfo
    {

        private string applicationTypeField;

        private string applicationNameField;

        private decimal applicationVerField;

        private string databaseVerField;

        private System.DateTime databaseDateTimeField;

        /// <remarks/>
        public string ApplicationType
        {
            get
            {
                return this.applicationTypeField;
            }
            set
            {
                this.applicationTypeField = value;
            }
        }

        /// <remarks/>
        public string ApplicationName
        {
            get
            {
                return this.applicationNameField;
            }
            set
            {
                this.applicationNameField = value;
            }
        }

        /// <remarks/>
        public decimal ApplicationVer
        {
            get
            {
                return this.applicationVerField;
            }
            set
            {
                this.applicationVerField = value;
            }
        }

        /// <remarks/>
        public string DatabaseVer
        {
            get
            {
                return this.databaseVerField;
            }
            set
            {
                this.databaseVerField = value;
            }
        }

        /// <remarks/>
        public System.DateTime DatabaseDateTime
        {
            get
            {
                return this.databaseDateTimeField;
            }
            set
            {
                this.databaseDateTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqEventInfo
    {

        private VehicleDamageEstimateAddRqEventInfoAssignmentEvent assignmentEventField;

        private VehicleDamageEstimateAddRqEventInfoEstimateEvent estimateEventField;

        /// <remarks/>
        public VehicleDamageEstimateAddRqEventInfoAssignmentEvent AssignmentEvent
        {
            get
            {
                return this.assignmentEventField;
            }
            set
            {
                this.assignmentEventField = value;
            }
        }

        /// <remarks/>
        public VehicleDamageEstimateAddRqEventInfoEstimateEvent EstimateEvent
        {
            get
            {
                return this.estimateEventField;
            }
            set
            {
                this.estimateEventField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqEventInfoAssignmentEvent
    {

        private System.DateTime inspectionDateTimeField;

        /// <remarks/>
        public System.DateTime InspectionDateTime
        {
            get
            {
                return this.inspectionDateTimeField;
            }
            set
            {
                this.inspectionDateTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqEventInfoEstimateEvent
    {

        private System.DateTime createDateTimeField;

        private System.DateTime commitDateTimeField;

        private System.DateTime uploadDateTimeField;

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
        public System.DateTime CommitDateTime
        {
            get
            {
                return this.commitDateTimeField;
            }
            set
            {
                this.commitDateTimeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime UploadDateTime
        {
            get
            {
                return this.uploadDateTimeField;
            }
            set
            {
                this.uploadDateTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqAdminInfo
    {

        private VehicleDamageEstimateAddRqAdminInfoOwner ownerField;

        private VehicleDamageEstimateAddRqAdminInfoEstimator estimatorField;

        private VehicleDamageEstimateAddRqAdminInfoSupplier[] supplierField;

        private VehicleDamageEstimateAddRqAdminInfoSender senderField;

        /// <remarks/>
        public VehicleDamageEstimateAddRqAdminInfoOwner Owner
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
        public VehicleDamageEstimateAddRqAdminInfoEstimator Estimator
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
        [System.Xml.Serialization.XmlElementAttribute("Supplier")]
        public VehicleDamageEstimateAddRqAdminInfoSupplier[] Supplier
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
        public VehicleDamageEstimateAddRqAdminInfoSender Sender
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqAdminInfoOwner
    {

        private VehicleDamageEstimateAddRqAdminInfoOwnerParty partyField;

        /// <remarks/>
        public VehicleDamageEstimateAddRqAdminInfoOwnerParty Party
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqAdminInfoOwnerParty
    {

        private VehicleDamageEstimateAddRqAdminInfoOwnerPartyPersonInfo personInfoField;

        /// <remarks/>
        public VehicleDamageEstimateAddRqAdminInfoOwnerPartyPersonInfo PersonInfo
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqAdminInfoOwnerPartyPersonInfo
    {

        private VehicleDamageEstimateAddRqAdminInfoOwnerPartyPersonInfoPersonName personNameField;

        private VehicleDamageEstimateAddRqAdminInfoOwnerPartyPersonInfoCommunications communicationsField;

        /// <remarks/>
        public VehicleDamageEstimateAddRqAdminInfoOwnerPartyPersonInfoPersonName PersonName
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
        public VehicleDamageEstimateAddRqAdminInfoOwnerPartyPersonInfoCommunications Communications
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqAdminInfoOwnerPartyPersonInfoPersonName
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqAdminInfoOwnerPartyPersonInfoCommunications
    {

        private string commQualifierField;

        private VehicleDamageEstimateAddRqAdminInfoOwnerPartyPersonInfoCommunicationsAddress addressField;

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
        public VehicleDamageEstimateAddRqAdminInfoOwnerPartyPersonInfoCommunicationsAddress Address
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqAdminInfoOwnerPartyPersonInfoCommunicationsAddress
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqAdminInfoEstimator
    {

        private VehicleDamageEstimateAddRqAdminInfoEstimatorParty partyField;

        private string affiliationField;

        /// <remarks/>
        public VehicleDamageEstimateAddRqAdminInfoEstimatorParty Party
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqAdminInfoEstimatorParty
    {

        private VehicleDamageEstimateAddRqAdminInfoEstimatorPartyPersonInfo personInfoField;

        /// <remarks/>
        public VehicleDamageEstimateAddRqAdminInfoEstimatorPartyPersonInfo PersonInfo
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqAdminInfoEstimatorPartyPersonInfo
    {

        private VehicleDamageEstimateAddRqAdminInfoEstimatorPartyPersonInfoPersonName personNameField;

        private VehicleDamageEstimateAddRqAdminInfoEstimatorPartyPersonInfoCommunications communicationsField;

        /// <remarks/>
        public VehicleDamageEstimateAddRqAdminInfoEstimatorPartyPersonInfoPersonName PersonName
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
        public VehicleDamageEstimateAddRqAdminInfoEstimatorPartyPersonInfoCommunications Communications
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqAdminInfoEstimatorPartyPersonInfoPersonName
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqAdminInfoEstimatorPartyPersonInfoCommunications
    {

        private string commQualifierField;

        private VehicleDamageEstimateAddRqAdminInfoEstimatorPartyPersonInfoCommunicationsAddress addressField;

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
        public VehicleDamageEstimateAddRqAdminInfoEstimatorPartyPersonInfoCommunicationsAddress Address
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqAdminInfoEstimatorPartyPersonInfoCommunicationsAddress
    {

        private string postalCodeField;

        private string countryCodeField;

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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqAdminInfoSupplier
    {

        private VehicleDamageEstimateAddRqAdminInfoSupplierParty partyField;

        /// <remarks/>
        public VehicleDamageEstimateAddRqAdminInfoSupplierParty Party
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqAdminInfoSupplierParty
    {

        private VehicleDamageEstimateAddRqAdminInfoSupplierPartyOrgInfo orgInfoField;

        private VehicleDamageEstimateAddRqAdminInfoSupplierPartyCommunications[] contactInfoField;

        /// <remarks/>
        public VehicleDamageEstimateAddRqAdminInfoSupplierPartyOrgInfo OrgInfo
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
        public VehicleDamageEstimateAddRqAdminInfoSupplierPartyCommunications[] ContactInfo
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqAdminInfoSupplierPartyOrgInfo
    {

        private string companyNameField;

        private VehicleDamageEstimateAddRqAdminInfoSupplierPartyOrgInfoIDInfo iDInfoField;

        private VehicleDamageEstimateAddRqAdminInfoSupplierPartyOrgInfoCommunications communicationsField;

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
        public VehicleDamageEstimateAddRqAdminInfoSupplierPartyOrgInfoIDInfo IDInfo
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
        public VehicleDamageEstimateAddRqAdminInfoSupplierPartyOrgInfoCommunications Communications
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqAdminInfoSupplierPartyOrgInfoIDInfo
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqAdminInfoSupplierPartyOrgInfoCommunications
    {

        private string commQualifierField;

        private VehicleDamageEstimateAddRqAdminInfoSupplierPartyOrgInfoCommunicationsAddress addressField;

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
        public VehicleDamageEstimateAddRqAdminInfoSupplierPartyOrgInfoCommunicationsAddress Address
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqAdminInfoSupplierPartyOrgInfoCommunicationsAddress
    {

        private string address1Field;

        private string cityField;

        private string stateProvinceField;

        private string postalCodeField;

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqAdminInfoSupplierPartyCommunications
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqAdminInfoSender
    {

        private VehicleDamageEstimateAddRqAdminInfoSenderParty partyField;

        /// <remarks/>
        public VehicleDamageEstimateAddRqAdminInfoSenderParty Party
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqAdminInfoSenderParty
    {

        private VehicleDamageEstimateAddRqAdminInfoSenderPartyOrgInfo orgInfoField;

        /// <remarks/>
        public VehicleDamageEstimateAddRqAdminInfoSenderPartyOrgInfo OrgInfo
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqAdminInfoSenderPartyOrgInfo
    {

        private string companyNameField;

        private VehicleDamageEstimateAddRqAdminInfoSenderPartyOrgInfoIDInfo iDInfoField;

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
        public VehicleDamageEstimateAddRqAdminInfoSenderPartyOrgInfoIDInfo IDInfo
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqAdminInfoSenderPartyOrgInfoIDInfo
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqEstimatorIDs
    {

        private string originalEstimatorIDField;

        private string currentEstimatorIDField;

        /// <remarks/>
        public string OriginalEstimatorID
        {
            get
            {
                return this.originalEstimatorIDField;
            }
            set
            {
                this.originalEstimatorIDField = value;
            }
        }

        /// <remarks/>
        public string CurrentEstimatorID
        {
            get
            {
                return this.currentEstimatorIDField;
            }
            set
            {
                this.currentEstimatorIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqClaimInfo
    {

        private string claimNumField;

        private VehicleDamageEstimateAddRqClaimInfoPolicyInfo policyInfoField;

        private VehicleDamageEstimateAddRqClaimInfoLossInfo lossInfoField;

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
        public VehicleDamageEstimateAddRqClaimInfoPolicyInfo PolicyInfo
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
        public VehicleDamageEstimateAddRqClaimInfoLossInfo LossInfo
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
    public partial class VehicleDamageEstimateAddRqClaimInfoPolicyInfo
    {

        private VehicleDamageEstimateAddRqClaimInfoPolicyInfoCoverageInfo coverageInfoField;

        /// <remarks/>
        public VehicleDamageEstimateAddRqClaimInfoPolicyInfoCoverageInfo CoverageInfo
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
    public partial class VehicleDamageEstimateAddRqClaimInfoPolicyInfoCoverageInfo
    {

        private VehicleDamageEstimateAddRqClaimInfoPolicyInfoCoverageInfoCoverage coverageField;

        /// <remarks/>
        public VehicleDamageEstimateAddRqClaimInfoPolicyInfoCoverageInfoCoverage Coverage
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
    public partial class VehicleDamageEstimateAddRqClaimInfoPolicyInfoCoverageInfoCoverage
    {

        private string coverageCategoryField;

        private VehicleDamageEstimateAddRqClaimInfoPolicyInfoCoverageInfoCoverageDeductibleInfo deductibleInfoField;

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
        public VehicleDamageEstimateAddRqClaimInfoPolicyInfoCoverageInfoCoverageDeductibleInfo DeductibleInfo
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
    public partial class VehicleDamageEstimateAddRqClaimInfoPolicyInfoCoverageInfoCoverageDeductibleInfo
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
    public partial class VehicleDamageEstimateAddRqClaimInfoLossInfo
    {

        private VehicleDamageEstimateAddRqClaimInfoLossInfoFacts factsField;

        private VehicleDamageEstimateAddRqClaimInfoLossInfoInspection inspectionField;

        private string totalLossIndField;

        /// <remarks/>
        public VehicleDamageEstimateAddRqClaimInfoLossInfoFacts Facts
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
        public VehicleDamageEstimateAddRqClaimInfoLossInfoInspection Inspection
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
    public partial class VehicleDamageEstimateAddRqClaimInfoLossInfoFacts
    {

        private System.DateTime lossDateTimeField;

        private byte theftIndField;

        private VehicleDamageEstimateAddRqClaimInfoLossInfoFactsPrimaryPOI primaryPOIField;

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
        public VehicleDamageEstimateAddRqClaimInfoLossInfoFactsPrimaryPOI PrimaryPOI
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
    public partial class VehicleDamageEstimateAddRqClaimInfoLossInfoFactsPrimaryPOI
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
    public partial class VehicleDamageEstimateAddRqClaimInfoLossInfoInspection
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqVehicleInfo
    {

        private VehicleDamageEstimateAddRqVehicleInfoVINInfo vINInfoField;

        private VehicleDamageEstimateAddRqVehicleInfoVehicleDesc vehicleDescField;

        private VehicleDamageEstimateAddRqVehicleInfoBody bodyField;

        private VehicleDamageEstimateAddRqVehicleInfoPowertrain powertrainField;

        private object conditionField;

        private string vehicleMemoField;

        /// <remarks/>
        public VehicleDamageEstimateAddRqVehicleInfoVINInfo VINInfo
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
        public VehicleDamageEstimateAddRqVehicleInfoVehicleDesc VehicleDesc
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
        public VehicleDamageEstimateAddRqVehicleInfoBody Body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
            }
        }

        /// <remarks/>
        public VehicleDamageEstimateAddRqVehicleInfoPowertrain Powertrain
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
        public object Condition
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqVehicleInfoVINInfo
    {

        private VehicleDamageEstimateAddRqVehicleInfoVINInfoVIN vINField;

        /// <remarks/>
        public VehicleDamageEstimateAddRqVehicleInfoVINInfoVIN VIN
        {
            get
            {
                return this.vINField;
            }
            set
            {
                this.vINField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqVehicleInfoVINInfoVIN
    {

        private string vINNumField;

        /// <remarks/>
        public string VINNum
        {
            get
            {
                return this.vINNumField;
            }
            set
            {
                this.vINNumField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqVehicleInfoVehicleDesc
    {

        private ushort modelYearField;

        private string makeDescField;

        private string modelNameField;

        private VehicleDamageEstimateAddRqVehicleInfoVehicleDescOdometerInfo odometerInfoField;

        private VehicleDamageEstimateAddRqVehicleInfoVehicleDescOption[] vehicleOptionsField;

        private string vehicleDescMemoField;

        private VehicleDamageEstimateAddRqVehicleInfoVehicleDescNICBInfo nICBInfoField;

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
        public VehicleDamageEstimateAddRqVehicleInfoVehicleDescOdometerInfo OdometerInfo
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
        public VehicleDamageEstimateAddRqVehicleInfoVehicleDescOption[] VehicleOptions
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
        public VehicleDamageEstimateAddRqVehicleInfoVehicleDescNICBInfo NICBInfo
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqVehicleInfoVehicleDescOdometerInfo
    {

        private byte odometerIndField;

        private string odometerReadingField;

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
        public string OdometerReading
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqVehicleInfoVehicleDescOption
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqVehicleInfoVehicleDescNICBInfo
    {

        private string nICBMakeField;

        private string nICBModelField;

        private string nICBBodyStyleField;

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

        /// <remarks/>
        public string NICBBodyStyle
        {
            get
            {
                return this.nICBBodyStyleField;
            }
            set
            {
                this.nICBBodyStyleField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqVehicleInfoBody
    {

        private string bodyStyleField;

        /// <remarks/>
        public string BodyStyle
        {
            get
            {
                return this.bodyStyleField;
            }
            set
            {
                this.bodyStyleField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqVehicleInfoPowertrain
    {

        private byte engineNumField;

        private string engineDescField;

        private string engineCodeField;

        private VehicleDamageEstimateAddRqVehicleInfoPowertrainTransmissionInfo transmissionInfoField;

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
        public VehicleDamageEstimateAddRqVehicleInfoPowertrainTransmissionInfo TransmissionInfo
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqVehicleInfoPowertrainTransmissionInfo
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqProfileInfo
    {

        private VehicleDamageEstimateAddRqProfileInfoRateInfo[] rateInfoField;

        private VehicleDamageEstimateAddRqProfileInfoAlternatePartInfo alternatePartInfoField;

        private byte costPlusBasisIndField;

        private byte drillTimeIndField;

        private byte edgingTimeIndField;

        private byte undersideTimeIndField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RateInfo")]
        public VehicleDamageEstimateAddRqProfileInfoRateInfo[] RateInfo
        {
            get
            {
                return this.rateInfoField;
            }
            set
            {
                this.rateInfoField = value;
            }
        }

        /// <remarks/>
        public VehicleDamageEstimateAddRqProfileInfoAlternatePartInfo AlternatePartInfo
        {
            get
            {
                return this.alternatePartInfoField;
            }
            set
            {
                this.alternatePartInfoField = value;
            }
        }

        /// <remarks/>
        public byte CostPlusBasisInd
        {
            get
            {
                return this.costPlusBasisIndField;
            }
            set
            {
                this.costPlusBasisIndField = value;
            }
        }

        /// <remarks/>
        public byte DrillTimeInd
        {
            get
            {
                return this.drillTimeIndField;
            }
            set
            {
                this.drillTimeIndField = value;
            }
        }

        /// <remarks/>
        public byte EdgingTimeInd
        {
            get
            {
                return this.edgingTimeIndField;
            }
            set
            {
                this.edgingTimeIndField = value;
            }
        }

        /// <remarks/>
        public byte UndersideTimeInd
        {
            get
            {
                return this.undersideTimeIndField;
            }
            set
            {
                this.undersideTimeIndField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqProfileInfoRateInfo
    {

        private string rateTypeField;

        private string rateDescField;

        private VehicleDamageEstimateAddRqProfileInfoRateInfoRateTierInfo rateTierInfoField;

        private byte taxableIndField;

        private bool taxableIndFieldSpecified;

        private VehicleDamageEstimateAddRqProfileInfoRateInfoMaterialCalcSettings materialCalcSettingsField;

        /// <remarks/>
        public string RateType
        {
            get
            {
                return this.rateTypeField;
            }
            set
            {
                this.rateTypeField = value;
            }
        }

        /// <remarks/>
        public string RateDesc
        {
            get
            {
                return this.rateDescField;
            }
            set
            {
                this.rateDescField = value;
            }
        }

        /// <remarks/>
        public VehicleDamageEstimateAddRqProfileInfoRateInfoRateTierInfo RateTierInfo
        {
            get
            {
                return this.rateTierInfoField;
            }
            set
            {
                this.rateTierInfoField = value;
            }
        }

        /// <remarks/>
        public byte TaxableInd
        {
            get
            {
                return this.taxableIndField;
            }
            set
            {
                this.taxableIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxableIndSpecified
        {
            get
            {
                return this.taxableIndFieldSpecified;
            }
            set
            {
                this.taxableIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        public VehicleDamageEstimateAddRqProfileInfoRateInfoMaterialCalcSettings MaterialCalcSettings
        {
            get
            {
                return this.materialCalcSettingsField;
            }
            set
            {
                this.materialCalcSettingsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqProfileInfoRateInfoRateTierInfo
    {

        private byte tierNumField;

        private decimal rateField;

        /// <remarks/>
        public byte TierNum
        {
            get
            {
                return this.tierNumField;
            }
            set
            {
                this.tierNumField = value;
            }
        }

        /// <remarks/>
        public decimal Rate
        {
            get
            {
                return this.rateField;
            }
            set
            {
                this.rateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqProfileInfoRateInfoMaterialCalcSettings
    {

        private byte calcMethodCodeField;

        private decimal calcMaxHoursField;

        private bool calcMaxHoursFieldSpecified;

        private decimal calcMaxAmtField;

        private bool calcMaxAmtFieldSpecified;

        /// <remarks/>
        public byte CalcMethodCode
        {
            get
            {
                return this.calcMethodCodeField;
            }
            set
            {
                this.calcMethodCodeField = value;
            }
        }

        /// <remarks/>
        public decimal CalcMaxHours
        {
            get
            {
                return this.calcMaxHoursField;
            }
            set
            {
                this.calcMaxHoursField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CalcMaxHoursSpecified
        {
            get
            {
                return this.calcMaxHoursFieldSpecified;
            }
            set
            {
                this.calcMaxHoursFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal CalcMaxAmt
        {
            get
            {
                return this.calcMaxAmtField;
            }
            set
            {
                this.calcMaxAmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CalcMaxAmtSpecified
        {
            get
            {
                return this.calcMaxAmtFieldSpecified;
            }
            set
            {
                this.calcMaxAmtFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqProfileInfoAlternatePartInfo
    {

        private string partTypeField;

        private string searchCodeField;

        private string beginSearchPostalCodeField;

        /// <remarks/>
        public string PartType
        {
            get
            {
                return this.partTypeField;
            }
            set
            {
                this.partTypeField = value;
            }
        }

        /// <remarks/>
        public string SearchCode
        {
            get
            {
                return this.searchCodeField;
            }
            set
            {
                this.searchCodeField = value;
            }
        }

        /// <remarks/>
        public string BeginSearchPostalCode
        {
            get
            {
                return this.beginSearchPostalCodeField;
            }
            set
            {
                this.beginSearchPostalCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqDamageLineInfo
    {

        private byte lineNumField;

        private byte parentLineNumField;

        private bool parentLineNumFieldSpecified;

        private byte manualLineIndField;

        private byte automatedEntryField;

        private byte lineStatusCodeField;

        private byte messageCodeField;

        private bool messageCodeFieldSpecified;

        private byte vendorRefNumField;

        private bool vendorRefNumFieldSpecified;

        private string lineDescField;

        private byte descJudgmentIndField;

        private string lineDescCodeField;

        private VehicleDamageEstimateAddRqDamageLineInfoPartInfo partInfoField;

        private VehicleDamageEstimateAddRqDamageLineInfoLaborInfo laborInfoField;

        /// <remarks/>
        public byte LineNum
        {
            get
            {
                return this.lineNumField;
            }
            set
            {
                this.lineNumField = value;
            }
        }

        /// <remarks/>
        public byte ParentLineNum
        {
            get
            {
                return this.parentLineNumField;
            }
            set
            {
                this.parentLineNumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ParentLineNumSpecified
        {
            get
            {
                return this.parentLineNumFieldSpecified;
            }
            set
            {
                this.parentLineNumFieldSpecified = value;
            }
        }

        /// <remarks/>
        public byte ManualLineInd
        {
            get
            {
                return this.manualLineIndField;
            }
            set
            {
                this.manualLineIndField = value;
            }
        }

        /// <remarks/>
        public byte AutomatedEntry
        {
            get
            {
                return this.automatedEntryField;
            }
            set
            {
                this.automatedEntryField = value;
            }
        }

        /// <remarks/>
        public byte LineStatusCode
        {
            get
            {
                return this.lineStatusCodeField;
            }
            set
            {
                this.lineStatusCodeField = value;
            }
        }

        /// <remarks/>
        public byte MessageCode
        {
            get
            {
                return this.messageCodeField;
            }
            set
            {
                this.messageCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MessageCodeSpecified
        {
            get
            {
                return this.messageCodeFieldSpecified;
            }
            set
            {
                this.messageCodeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public byte VendorRefNum
        {
            get
            {
                return this.vendorRefNumField;
            }
            set
            {
                this.vendorRefNumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VendorRefNumSpecified
        {
            get
            {
                return this.vendorRefNumFieldSpecified;
            }
            set
            {
                this.vendorRefNumFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string LineDesc
        {
            get
            {
                return this.lineDescField;
            }
            set
            {
                this.lineDescField = value;
            }
        }

        /// <remarks/>
        public byte DescJudgmentInd
        {
            get
            {
                return this.descJudgmentIndField;
            }
            set
            {
                this.descJudgmentIndField = value;
            }
        }

        /// <remarks/>
        public string LineDescCode
        {
            get
            {
                return this.lineDescCodeField;
            }
            set
            {
                this.lineDescCodeField = value;
            }
        }

        /// <remarks/>
        public VehicleDamageEstimateAddRqDamageLineInfoPartInfo PartInfo
        {
            get
            {
                return this.partInfoField;
            }
            set
            {
                this.partInfoField = value;
            }
        }

        /// <remarks/>
        public VehicleDamageEstimateAddRqDamageLineInfoLaborInfo LaborInfo
        {
            get
            {
                return this.laborInfoField;
            }
            set
            {
                this.laborInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqDamageLineInfoPartInfo
    {

        private string partTypeField;

        private string partNumField;

        private string oEMPartNumField;

        private VehicleDamageEstimateAddRqDamageLineInfoPartInfoNonOEM[] nonOEMField;

        private decimal partPriceField;

        private bool partPriceFieldSpecified;

        private decimal oEMPartPriceField;

        private bool oEMPartPriceFieldSpecified;

        private byte taxableIndField;

        private string afterMarketUsageField;

        private byte priceJudgmentIndField;

        private byte glassPartIndField;

        private byte priceInclIndField;

        /// <remarks/>
        public string PartType
        {
            get
            {
                return this.partTypeField;
            }
            set
            {
                this.partTypeField = value;
            }
        }

        /// <remarks/>
        public string PartNum
        {
            get
            {
                return this.partNumField;
            }
            set
            {
                this.partNumField = value;
            }
        }

        /// <remarks/>
        public string OEMPartNum
        {
            get
            {
                return this.oEMPartNumField;
            }
            set
            {
                this.oEMPartNumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NonOEM")]
        public VehicleDamageEstimateAddRqDamageLineInfoPartInfoNonOEM[] NonOEM
        {
            get
            {
                return this.nonOEMField;
            }
            set
            {
                this.nonOEMField = value;
            }
        }

        /// <remarks/>
        public decimal PartPrice
        {
            get
            {
                return this.partPriceField;
            }
            set
            {
                this.partPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PartPriceSpecified
        {
            get
            {
                return this.partPriceFieldSpecified;
            }
            set
            {
                this.partPriceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal OEMPartPrice
        {
            get
            {
                return this.oEMPartPriceField;
            }
            set
            {
                this.oEMPartPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OEMPartPriceSpecified
        {
            get
            {
                return this.oEMPartPriceFieldSpecified;
            }
            set
            {
                this.oEMPartPriceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public byte TaxableInd
        {
            get
            {
                return this.taxableIndField;
            }
            set
            {
                this.taxableIndField = value;
            }
        }

        /// <remarks/>
        public string AfterMarketUsage
        {
            get
            {
                return this.afterMarketUsageField;
            }
            set
            {
                this.afterMarketUsageField = value;
            }
        }

        /// <remarks/>
        public byte PriceJudgmentInd
        {
            get
            {
                return this.priceJudgmentIndField;
            }
            set
            {
                this.priceJudgmentIndField = value;
            }
        }

        /// <remarks/>
        public byte GlassPartInd
        {
            get
            {
                return this.glassPartIndField;
            }
            set
            {
                this.glassPartIndField = value;
            }
        }

        /// <remarks/>
        public byte PriceInclInd
        {
            get
            {
                return this.priceInclIndField;
            }
            set
            {
                this.priceInclIndField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqDamageLineInfoPartInfoNonOEM
    {

        private string partTypeField;

        private string nonOEMPartNumField;

        private decimal nonOEMPartPriceField;

        private string supplierRefNumField;

        private byte partSelectedIndField;

        /// <remarks/>
        public string PartType
        {
            get
            {
                return this.partTypeField;
            }
            set
            {
                this.partTypeField = value;
            }
        }

        /// <remarks/>
        public string NonOEMPartNum
        {
            get
            {
                return this.nonOEMPartNumField;
            }
            set
            {
                this.nonOEMPartNumField = value;
            }
        }

        /// <remarks/>
        public decimal NonOEMPartPrice
        {
            get
            {
                return this.nonOEMPartPriceField;
            }
            set
            {
                this.nonOEMPartPriceField = value;
            }
        }

        /// <remarks/>
        public string SupplierRefNum
        {
            get
            {
                return this.supplierRefNumField;
            }
            set
            {
                this.supplierRefNumField = value;
            }
        }

        /// <remarks/>
        public byte PartSelectedInd
        {
            get
            {
                return this.partSelectedIndField;
            }
            set
            {
                this.partSelectedIndField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqDamageLineInfoLaborInfo
    {

        private string laborTypeField;

        private string laborOperationField;

        private decimal laborHoursField;

        private decimal databaseLaborHoursField;

        private byte laborInclIndField;

        private byte laborAmtJudgmentIndField;

        private bool laborAmtJudgmentIndFieldSpecified;

        private byte laborHoursJudgmentIndField;

        private byte laborOperationJudgmentIndField;

        private byte laborTypeJudgmentIndField;

        /// <remarks/>
        public string LaborType
        {
            get
            {
                return this.laborTypeField;
            }
            set
            {
                this.laborTypeField = value;
            }
        }

        /// <remarks/>
        public string LaborOperation
        {
            get
            {
                return this.laborOperationField;
            }
            set
            {
                this.laborOperationField = value;
            }
        }

        /// <remarks/>
        public decimal LaborHours
        {
            get
            {
                return this.laborHoursField;
            }
            set
            {
                this.laborHoursField = value;
            }
        }

        /// <remarks/>
        public decimal DatabaseLaborHours
        {
            get
            {
                return this.databaseLaborHoursField;
            }
            set
            {
                this.databaseLaborHoursField = value;
            }
        }

        /// <remarks/>
        public byte LaborInclInd
        {
            get
            {
                return this.laborInclIndField;
            }
            set
            {
                this.laborInclIndField = value;
            }
        }

        /// <remarks/>
        public byte LaborAmtJudgmentInd
        {
            get
            {
                return this.laborAmtJudgmentIndField;
            }
            set
            {
                this.laborAmtJudgmentIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LaborAmtJudgmentIndSpecified
        {
            get
            {
                return this.laborAmtJudgmentIndFieldSpecified;
            }
            set
            {
                this.laborAmtJudgmentIndFieldSpecified = value;
            }
        }

        /// <remarks/>
        public byte LaborHoursJudgmentInd
        {
            get
            {
                return this.laborHoursJudgmentIndField;
            }
            set
            {
                this.laborHoursJudgmentIndField = value;
            }
        }

        /// <remarks/>
        public byte LaborOperationJudgmentInd
        {
            get
            {
                return this.laborOperationJudgmentIndField;
            }
            set
            {
                this.laborOperationJudgmentIndField = value;
            }
        }

        /// <remarks/>
        public byte LaborTypeJudgmentInd
        {
            get
            {
                return this.laborTypeJudgmentIndField;
            }
            set
            {
                this.laborTypeJudgmentIndField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqRepairTotalsInfo
    {

        private VehicleDamageEstimateAddRqRepairTotalsInfoPartsTotalsInfo[] partsTotalsInfoField;

        private VehicleDamageEstimateAddRqRepairTotalsInfoSummaryTotalsInfo[] summaryTotalsInfoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PartsTotalsInfo")]
        public VehicleDamageEstimateAddRqRepairTotalsInfoPartsTotalsInfo[] PartsTotalsInfo
        {
            get
            {
                return this.partsTotalsInfoField;
            }
            set
            {
                this.partsTotalsInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SummaryTotalsInfo")]
        public VehicleDamageEstimateAddRqRepairTotalsInfoSummaryTotalsInfo[] SummaryTotalsInfo
        {
            get
            {
                return this.summaryTotalsInfoField;
            }
            set
            {
                this.summaryTotalsInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqRepairTotalsInfoPartsTotalsInfo
    {

        private string totalTypeField;

        private string totalTypeDescField;

        private decimal totalAmtField;

        /// <remarks/>
        public string TotalType
        {
            get
            {
                return this.totalTypeField;
            }
            set
            {
                this.totalTypeField = value;
            }
        }

        /// <remarks/>
        public string TotalTypeDesc
        {
            get
            {
                return this.totalTypeDescField;
            }
            set
            {
                this.totalTypeDescField = value;
            }
        }

        /// <remarks/>
        public decimal TotalAmt
        {
            get
            {
                return this.totalAmtField;
            }
            set
            {
                this.totalAmtField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cieca.com/BMS")]
    public partial class VehicleDamageEstimateAddRqRepairTotalsInfoSummaryTotalsInfo
    {

        private string totalTypeField;

        private string totalSubTypeField;

        private string totalTypeDescField;

        private decimal totalAmtField;

        /// <remarks/>
        public string TotalType
        {
            get
            {
                return this.totalTypeField;
            }
            set
            {
                this.totalTypeField = value;
            }
        }

        /// <remarks/>
        public string TotalSubType
        {
            get
            {
                return this.totalSubTypeField;
            }
            set
            {
                this.totalSubTypeField = value;
            }
        }

        /// <remarks/>
        public string TotalTypeDesc
        {
            get
            {
                return this.totalTypeDescField;
            }
            set
            {
                this.totalTypeDescField = value;
            }
        }

        /// <remarks/>
        public decimal TotalAmt
        {
            get
            {
                return this.totalAmtField;
            }
            set
            {
                this.totalAmtField = value;
            }
        }
    }


}
