using CMS.BL.Contract;

namespace CMS.BL.Entities
{
    public class CategoryDto : BaseEntity
    {
        public System.Guid CategoryId { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
    }
}
