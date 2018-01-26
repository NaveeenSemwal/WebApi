using System;

namespace CMS.BL.Contract
{
    public abstract class BaseEntity
    {
        public Int64 ID { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
