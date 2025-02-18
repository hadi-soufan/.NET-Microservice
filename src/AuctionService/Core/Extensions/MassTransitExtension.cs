using AuctionService.Consumers;
using AuctionService.Models;
using MassTransit;

namespace AuctionService.Core.Extensions
{
    public static class MassTransitExtension
    {
        public static IServiceCollection AddRabbitMqMassTransit(this IServiceCollection services)
        {
            services.AddMassTransit(m =>
            {
                m.AddEntityFrameworkOutbox<AuctionDbContext>(o =>
                {
                    o.QueryDelay = TimeSpan.FromSeconds(10);

                    o.UsePostgres();
                    o.UseBusOutbox();
                });

                m.AddConsumersFromNamespaceContaining<AuctionCreatedFaultConsumer>();

                m.SetEndpointNameFormatter(new KebabCaseEndpointNameFormatter("auction", false));

                m.UsingRabbitMq((context, cfg) =>
                {
                    cfg.ConfigureEndpoints(context);
                });
            });

            return services;
        }
    }
}
