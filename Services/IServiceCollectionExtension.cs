using Microsoft.Extensions.DependencyInjection;
using Services.Interfaces;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IDroneService, DroneService>();
            services.AddScoped<IMedicationService, MedicationService>();

            return services;
        }
    }
}
