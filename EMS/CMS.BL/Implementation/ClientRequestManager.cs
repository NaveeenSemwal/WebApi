using AutoMapper;
using CMS.BL.Contract;
using CMS.BL.Entities;
using CMS.DB.Contract;
using CMS.DB.Implementation;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMS.BL.Implementation
{
    public class ClientRequestManager : IClientRequestManager
    {
        readonly IClientRequestAliasRepository clientRequestAliasRepository;

        public ClientRequestManager()
        {
            clientRequestAliasRepository = new ClientRequestAliasRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ClientRequestAlias>> GetAllClientAlias()
        {
            var clientRequestAliasList = await clientRequestAliasRepository.GetAllClientAlias();
            IEnumerable<ClientRequestAlias> clientRequestAlias = Mapper.Map<IEnumerable<ClientRequestAlias>>(clientRequestAliasList);
            return clientRequestAlias;
        }
    }
}
