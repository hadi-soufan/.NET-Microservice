using Mapster;
using MapsterMapper;
using SearchService.RequestHelpers;

namespace SearchService.Cores.Extensions
{
    public static class MapsterExtension
    {
        public static IServiceCollection AddMapsterConfiguration(this IServiceCollection services)
        {
            var config = TypeAdapterConfig.GlobalSettings;
            config.Scan(typeof(MappingProfiles).Assembly);

            services.AddSingleton(config);
            services.AddScoped<IMapper, ServiceMapper>();

            return services;
        }
    }
}
