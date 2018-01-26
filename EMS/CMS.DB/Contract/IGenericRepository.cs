using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.DB.GenericRepository
{
    public interface IGenericRepository<Entity> where Entity : class
    {
        IEnumerable<Entity>  GetAll();
        Entity GetById(object Id);
        void Insert(Entity obj);
        void Delete(object Id);
        void Update(Entity obj);
        void Save();
    }
}
