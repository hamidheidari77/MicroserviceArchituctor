using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Actio.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult Get() => Content("Heloo");
    }
}
