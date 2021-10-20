using AutoMapper;
using Events.Data.Context;
using Events.Data.Models.Configuration;
using Events.Data.Repositories.Implementations;
using Events.Data.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
//using Events.Models
using System.Text;
using System.Threading.Tasks;

namespace Events.Data.Configuration
{
    public static class DataConfiguration
    {
        public static void ConfigureData(this IServiceCollection services, string enviormentName)
        {
            services.AddDbContext<EventsContext>(item => item.UseSqlServer(ConfigurationManager.AppSetting["DataSettings:ConnectionString:DefaultConnection"]), ServiceLifetime.Singleton);

            services.AddTransient<EventsContext>();

            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));

            services.AddTransient<IUow, Uow>();
        }
    }
}
