using CMS.DB.DataModel;
using CMS.DB.GenericRepository;

namespace CMS.DB
{
    public interface IUnitOfWork
    {
        IGenericRepository<Category> CategoryRepository { get; }
        void Commit();
    }
}
