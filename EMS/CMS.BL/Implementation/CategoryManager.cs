using AutoMapper;
using CMS.BL.Contract;
using CMS.BL.Entities;
using CMS.DB.Contract;
using CMS.DB.Implementation;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMS.BL.Implementation
{
    /// <summary>
    /// Implemantation of Automapper.
    /// </summary>
    public class CategoryManager  : IManagerBase<CategoryDto,int>
    {
        readonly ICategoryRepository _clientRequestAliasRepository;

        public CategoryManager(ICategoryRepository clientRequestAliasRepository)
        {
            _clientRequestAliasRepository = clientRequestAliasRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<CategoryDto>> GetAll()
        {
            var categoryList = await _clientRequestAliasRepository.GetAllCategories();
            IEnumerable<CategoryDto> categoryDtoList = Mapper.Map<IEnumerable<CategoryDto>>(categoryList);
            return categoryDtoList;
        }

        public async Task<CategoryDto> GetById(int id)
        {
            var category = await _clientRequestAliasRepository.GetCategoryById(id);
            CategoryDto categoryDto = Mapper.Map<CategoryDto>(category);
            return categoryDto;
        }
    }
}
