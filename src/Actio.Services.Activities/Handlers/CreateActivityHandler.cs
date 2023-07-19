using Actio.Common.Commands;
using Actio.Common.Events;
using RawRabbit;
using System;
using System.Threading.Tasks;

namespace Actio.Services.Activities.Handlers
{
    public class CreateActivityHandler : ICommandHandler<CreateActivity>
    {
        private readonly IBusClient _busclient;
        public CreateActivityHandler(IBusClient busclient)
        {
            _busclient = busclient;
        }
        public async Task HandleAsync(CreateActivity command)
        {
            Console.WriteLine($"Create Activity :{command.UserId}");
            await _busclient.PublishAsync(new ActivityCreated(command.Id,
                command.UserId,
                   command.Name,
                command.Description,
                command.Category,
                command.CreatedAt
                ));
        }
    }
}
