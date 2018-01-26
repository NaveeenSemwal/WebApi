using CMS.BL.Contract;

namespace CMS.BL.Entities
{
    public class ClientRequestAlias : BaseEntity
    {
        public int RequestDetailID { get; set; }
        public string MessageId { get; set; }
        public string AuditId { get; set; }
        public string ClientRequestXml { get; set; }
        public string ClientResponseXml { get; set; }
        public bool ClientStatus { get; set; }
        public string ClientNumber { get; set; }
    }
}
