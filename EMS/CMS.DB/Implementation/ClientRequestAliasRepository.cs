using CMS.DB.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.DB.DataModel;
using CMS.DB;
using CMS.DB.GenericRepository;

namespace CMS.DB.Implementation
{
    public class ClientRequestAliasRepository : IClientRequestAliasRepository
    {
        private readonly UnitOfWork unitOfWork = new UnitOfWork();

        public async Task<IEnumerable<ClientRequestAlia>> GetAllClientAlias()
        {
            Task<IEnumerable<ClientRequestAlia>> clientRequestAliasList = Task.Run(() => unitOfWork.ClientRequestAliasRepository.GetAll());
            return await clientRequestAliasList;
        }
    }
}
