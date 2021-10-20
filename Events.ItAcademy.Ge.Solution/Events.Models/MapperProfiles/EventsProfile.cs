using AutoMapper;
using Events.Data.Models.Entities;
using Events.Models.Dtos.Events;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Models.MapperProfiles
{
    public class EventsProfile : Profile
    {
        public EventsProfile()
        {
            CreateMap<Event, EventDto>()
                .ForMember(
                    dest => dest.Name,
                    opt => opt.MapFrom(src => src.Name))
                .ForMember(
                    dest => dest.Location,
                    opt => opt.MapFrom(src => src.Location))
                .ForMember(
                    dest => dest.ImageUrl,
                    opt => opt.MapFrom(src => src.Image))
                .ForMember(
                    dest => dest.Month,
                    opt => opt.MapFrom(src => src.Date.ToString("MMM", CultureInfo.InvariantCulture)))
                .ForMember(
                    dest => dest.Year,
                    opt => opt.MapFrom(src => src.Date.Year))
                .ForMember(
                    dest => dest.Day,
                    opt => opt.MapFrom(src => src.Date.Day))
                .ForMember(
                    dest => dest.Location,
                    opt => opt.MapFrom(src => src.Location))
                .ReverseMap();
        }
    }
}
