using MassTransit;
using SearchService.Cores.Consumers;

namespace SearchService.Cores.Extensions
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
                    cfg.ReceiveEndpoint("search-auction-created", e =>
                    {
                        e.UseMessageRetry(r => r.Interval(5, 5));

                        e.ConfigureConsumer<AuctionCreatedConsumer>(context);
                    });

                    cfg.ConfigureEndpoints(context);
                });
            });

            return services;
        }
    }
}
