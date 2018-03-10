using CMS.DB.Contract;
using CMS.DB.DataModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMS.DB.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly UnitOfWork unitOfWork = new UnitOfWork();

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            Task<IEnumerable<Category>> clientRequestAliasList = Task.Run(() => this.unitOfWork.CategoryRepository.GetAll());
            return await clientRequestAliasList;
        }

        public async Task<Category> GetCategoryById(object Id)
        {
            Task<Category> category = Task.Run(() => unitOfWork.CategoryRepository.GetById(Id));
            return await category;
        }
    }
}
