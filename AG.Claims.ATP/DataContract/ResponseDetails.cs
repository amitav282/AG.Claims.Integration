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
    public class ResponseDetails
    {
        #region DataMembers
        [DataMember(Name = "success")]
        public string Success { get; set; }
        [DataMember(Name = "token")]
        public string Token { get; set; }
        [DataMember(Name = "stock_number")]
        public string StockNumber { get; set; }
        [DataMember(Name = "error")]
        public string Error { get; set; }
        [DataMember(Name = "response")]
        public string Response { get; set; }
        #endregion

        #region Constructor
        public ResponseDetails()
        {

        }
        #endregion
    }
}
