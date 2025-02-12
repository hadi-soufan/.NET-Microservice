using MassTransit;
using SearchService.Cores.Consumers;

namespace AuctionService.Core.Extensions
{
    public static class MassTransitExtension
    {
        public static IServiceCollection AddRabbitMqMassTransit(this IServiceCollection services)
        {
            services.AddMassTransit(m =>
            {
                m.AddConsumersFromNamespaceContaining<AuctionCreatedConsumer>();

                m.SetEndpointNameFormatter(new KebabCaseEndpointNameFormatter("search", false));

                m.UsingRabbitMq((context, cfg) =>
                {
                    cfg.ConfigureEndpoints(context);
                });
            });

            return services;
        }
    }
}
