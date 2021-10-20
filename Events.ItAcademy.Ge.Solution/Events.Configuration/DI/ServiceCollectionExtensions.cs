using AutoMapper;
using Events.Data.Configuration;
using Events.Data.Context;
using Events.Models.MapperProfiles;
using EventsService.Interfaces;
using EventsService.Implementations;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Configuration.DI
{
    public static class ServiceCollectionExtensions
    {
        public static void ConfigureBusinessServices(this IServiceCollection services, string enviormentName)
        {
            services.ConfigureData(enviormentName);

            services.AddTransient<IEventsService, EventsService.Implementations.EventsService>();

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new EventsProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();

            services.AddSingleton(mapper);
        }

        public static void AddIdentity(this IServiceCollection services)
        {

            services.AddIdentityCore<IdentityUser>()
                   .AddEntityFrameworkStores<EventsContext>();


        }
    }
}
