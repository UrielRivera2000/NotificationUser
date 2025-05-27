using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notification.Application.Interfaces;
using Notification.Infrastructure.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace Notification.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddLoggingAdapter(this IServiceCollection services)
        {
            services.AddScoped(typeof(ILoggerAdapter<>), typeof(Log4NetAdapter<>));
            return services;
        }
    }
}
