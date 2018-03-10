using CMS.DB.DataModel;
using CMS.DB.GenericRepository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMS.DB.Contract
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllCategories();

        Task<Category> GetCategoryById(object Id);
    }
}
