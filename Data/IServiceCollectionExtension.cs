using Data.Interfaces;
using Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
namespace Data
{ 
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection RegisterData(this IServiceCollection services)
        {
            services.AddMemoryCache();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IDroneRepository , DroneRepository>();
            services.AddScoped<IMedicationRepository, MedicationRepository>();

            return services;
        }
    }
}