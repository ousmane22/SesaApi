using Microsoft.AspNetCore.Mvc;

namespace SesaPay.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
