using CMS.DB.DataModel;
using CMS.DB.GenericRepository;

namespace CMS.DB
{
    public interface IUnitOfWork
    {
        IGenericRepository<ClientRequestAlia> ClientRequestAliasRepository { get; }
        void Commit();
    }
}
