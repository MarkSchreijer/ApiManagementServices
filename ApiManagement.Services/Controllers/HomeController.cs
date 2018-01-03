using System.Web.Http;

namespace ApiManagement.Services.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Index()
        {
            return Ok("Mijn eerste API in Api Management");
        }
    }
}