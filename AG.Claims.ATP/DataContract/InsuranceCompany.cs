using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace AG.Claims.ATP.DataContract
{
    [DataContract(Namespace = "")]
    public class InsuranceCompany
    {
        #region DataMembers
      
        [DataMember(Name = "api_token")]
        public string ApiToken { get; set; }

        [DataMember(Name = "api_hash")]
        public string ApiHash { get; set; }

        #endregion

        #region Constructor
        public InsuranceCompany()
        {

        }

        #endregion
    }
}
