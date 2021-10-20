using Events.Models.Dtos.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsService.Interfaces
{
    public interface IEventsService
    {
        List<EventDto> GetActiveEvents(); 
    }
}
