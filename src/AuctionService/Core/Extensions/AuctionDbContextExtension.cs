using AuctionService.Models;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.Core.Extensions
{
    public static class AuctionDbContextExtension
    {
        public static IServiceCollection AddAuctionDbContextExtensionService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AuctionDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            });
            return services;
        }
    }
}
