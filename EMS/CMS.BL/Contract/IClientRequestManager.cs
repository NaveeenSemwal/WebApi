using CMS.BL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BL.Contract
{
    public interface IClientRequestManager
    {
        Task<IEnumerable<ClientRequestAlias>> GetAllClientAlias();
    }
}
