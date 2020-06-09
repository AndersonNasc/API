using Domain.Interfaces.Service.Client;
using Microsoft.Extensions.DependencyInjection;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenceiesService(IServiceCollection servicesCollection)
        {
            servicesCollection.AddTransient<IClientService, ClientService>();
        }
    }
}
