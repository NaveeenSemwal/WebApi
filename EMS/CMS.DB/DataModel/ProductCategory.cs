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
    
    public partial class ProductCategory
    {
        public int Id { get; set; }
        public System.Guid CategoryId { get; set; }
        public System.Guid ProductId { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    }
}
