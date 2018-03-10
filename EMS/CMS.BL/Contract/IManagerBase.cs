using CMS.BL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BL.Contract
{
    public interface IManagerBase<Entity,Key> where Entity : BaseEntity
    {
        Task<IEnumerable<Entity>> GetAll();
        Task<CategoryDto> GetById(Key id);

    }
}
