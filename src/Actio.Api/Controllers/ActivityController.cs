using Actio.Common.Commands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RawRabbit;
using System;
using System.Threading.Tasks;

namespace Actio.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IBusClient _busclient;
        public ActivityController(BusClient busclient)
        {
            _busclient = busclient;
        }
        [HttpPost]
        [Route("CreateActivity")]
        public async Task<IActionResult> post(CreateActivity command)
        {
            command.Id= Guid.NewGuid();
            command.CreatedAt= DateTime.Now;
            await _busclient.PublishAsync(command); 
            return Accepted($"activities/{command.Id}");
        }
    }
}
