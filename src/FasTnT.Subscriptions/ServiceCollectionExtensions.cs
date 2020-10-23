﻿using Microsoft.Extensions.DependencyInjection;
using MediatR;
using Microsoft.Extensions.Hosting;

namespace FasTnT.Subscriptions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBackgroundSubscriptionService(this IServiceCollection services)
        {
            services.AddMediatR(SubscriptionRunner.Assembly);
            services.AddSingleton<SubscriptionBackgroundService>();
            services.AddHostedService(s => s.GetRequiredService<SubscriptionBackgroundService>());
            services.AddScoped<SubscriptionRunner>();
            services.AddScoped<SubscriptionResultSender>();

            return services;
        }
    }
}
