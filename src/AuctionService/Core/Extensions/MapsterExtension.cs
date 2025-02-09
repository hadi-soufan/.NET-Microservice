using AuctionService.RequestHelpers;
using Mapster;
using MapsterMapper;

namespace AuctionService.Core.Extensions
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
