using Data.Context;
using Data.Repository;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenceiesRepository(IServiceCollection servicesCollection)
        {
            servicesCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

            servicesCollection.AddDbContext<Context>(options => options.UseSqlServer("Server=.\\SQLEXPRESS;Database=dbApi;User Id=User_AirLiquide;Password=12345"));
        }
    }
}
