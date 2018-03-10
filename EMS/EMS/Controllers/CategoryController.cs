using CMS.BL.Contract;
using CMS.BL.Entities;
using CMS.BL.Implementation;
using CMS.Common.Log4Net;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;

namespace EMS.Controllers
{
    [RoutePrefix("api/categories")]
    public class CategoryController : ApiController
    {
        readonly IManagerBase<CategoryDto,int> _categoryManager;

        public CategoryController(IManagerBase<CategoryDto, int> categoryManager)
        {
            _categoryManager = categoryManager;
        }


        /// <summary>
        /// http://localhost:59026/api/categories
        /// </summary>
        /// <returns></returns>
        [Route("")]
        [ResponseType(typeof(CategoryDto))]
        public async Task<IHttpActionResult> GetAllCategories()
        {
            Log4NetLogger logger = new Log4NetLogger();

            logger.Info("Hi There this is naveen");

            var clientRequests = await _categoryManager.GetAll();

            if (clientRequests == null)
                return NotFound();

            return Ok(clientRequests);
        }


        /// <summary>
        /// http://localhost:59026/api/categories
        /// </summary>
        /// <returns></returns>
        [Route("{id:int}")]
        [ResponseType(typeof(CategoryDto))]
        public async Task<IHttpActionResult> GetCategoriesById(int id)
        {
            Log4NetLogger logger = new Log4NetLogger();

            logger.Info("Hi There this is naveen");

            var clientRequests = await _categoryManager.GetById(id);

            if (clientRequests == null)
                return NotFound();

            return Ok(clientRequests);
        }



        /// <summary>
        /// Uploading file from Angular 4 application or from AJAX.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("PostFileWithData")]
        public HttpResponseMessage Post()
        {
            HttpResponseMessage result = null;
            var httpRequest = HttpContext.Current.Request;

            if (httpRequest.Files.Count > 0)
            {
                var docfiles = new List<string>();

                foreach (string file in httpRequest.Files)
                {
                    var postedFile = httpRequest.Files[file];

                    var filePath = HttpContext.Current.Server.MapPath("~/" + postedFile.FileName);

                     postedFile.SaveAs(filePath);

                    docfiles.Add(filePath);
                }
                result = Request.CreateResponse(HttpStatusCode.Created, docfiles);
            }
            else
            {
                result = Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            return result;
        }
    }
}
