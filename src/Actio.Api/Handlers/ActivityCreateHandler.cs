using Actio.Common.Commands;
using Actio.Common.Events;
using System;
using System.Threading.Tasks;

namespace Actio.Api.Handlers
{
    public class ActivityCreateHandler : IEventHandler<ActivityCreated>
    {
        

        public async Task HandleAsync(ActivityCreated @event)
        {
            await Task.CompletedTask;
            Console.WriteLine($"Actitviy Created :{@event.Name}");
        }
    }
}
