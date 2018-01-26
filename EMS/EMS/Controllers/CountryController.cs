using CMS.BL.Contract;
using CMS.BL.Implementation;
using CMS.Common.Log4Net;
using System.Threading.Tasks;
using System.Web.Http;

namespace EMS.Controllers
{
    public class CountryController : ApiController
    {
        readonly IClientRequestManager _clientRequestManager;

        public CountryController()
        {
           _clientRequestManager = new ClientRequestManager();
        }

        public async Task<IHttpActionResult> GetAllClientAlias()
        {
            Log4NetLogger logger = new Log4NetLogger();

            logger.Info("Hi There this is naveen");

            var clientRequests = await _clientRequestManager.GetAllClientAlias();

            if (clientRequests == null)
                return NotFound();

            return Ok(clientRequests);
        }
    }
}
