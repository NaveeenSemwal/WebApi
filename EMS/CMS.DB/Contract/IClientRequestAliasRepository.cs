using CMS.DB.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.DB.Contract
{
    public interface IClientRequestAliasRepository
    {
        Task<IEnumerable<ClientRequestAlia>> GetAllClientAlias();
    }
}
