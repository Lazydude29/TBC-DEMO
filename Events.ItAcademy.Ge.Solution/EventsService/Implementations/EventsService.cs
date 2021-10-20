using AutoMapper;
using Events.Data.Repositories.Interfaces;
using Events.Models.Dtos.Events;
using EventsService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsService.Implementations
{
    public class EventsService : IEventsService
    {
        private readonly IUow _uow;
        private readonly IMapper _mapper;

        public EventsService(IUow uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public List<EventDto> GetActiveEvents()
        {
            var events = _uow.Events.Where(x => x.IsActive == true).ToList();

            var eventDtos = _mapper.Map<List<EventDto>>(events);

            return eventDtos;
        }
    }
}
