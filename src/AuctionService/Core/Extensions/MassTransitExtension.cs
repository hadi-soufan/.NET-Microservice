using MassTransit;

namespace AuctionService.Core.Extensions
{
    public static class MassTransitExtension
    {
        public static IServiceCollection AddRabbitMqMassTransit(this IServiceCollection services)
        {
            services.AddMassTransit(m =>
            {
                m.UsingRabbitMq((context, cfg) =>
                {
                    cfg.ConfigureEndpoints(context);
                });
            });

            return services;
        }
    }
}
