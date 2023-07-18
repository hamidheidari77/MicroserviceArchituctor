using Actio.Common.Commands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RawRabbit;
using System.Threading.Tasks;

namespace Actio.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IBusClient _busclient;
        public UsersController(BusClient busclient)
        {
            _busclient = busclient;
        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateUser command)
        {
            await _busclient.PublishAsync(command);
            return Accepted();
        }
    }
}
