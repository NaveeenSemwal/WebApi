using AutoMapper;
using CMS.BL.Entities;
using CMS.DB.DataModel;

namespace CMS.BL.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize((config) =>
            {
                config.CreateMap<Category, CategoryDto>().ReverseMap();
            });
        }
    }
}
