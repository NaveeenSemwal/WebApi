//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CMS.DB.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClientRequestAlia
    {
        public int ClientRequestAliasId { get; set; }
        public int RequestDetailID { get; set; }
        public string MessageId { get; set; }
        public string AuditId { get; set; }
        public string ClientRequestXml { get; set; }
        public string ClientResponseXml { get; set; }
        public bool ClientStatus { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ClientNumber { get; set; }
    }
}