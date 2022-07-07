using Microsoft.Extensions.DependencyInjection;
using Ayandeh.Faraz.HealthChecks;

namespace Ayandeh.Faraz.Web.HealthCheck
{
    public static class AbpZeroHealthCheck
    {
        public static IHealthChecksBuilder AddAbpZeroHealthCheck(this IServiceCollection services)
        {
            var builder = services.AddHealthChecks();
            builder.AddCheck<FarazDbContextHealthCheck>("Database Connection");
            builder.AddCheck<FarazDbContextUsersHealthCheck>("Database Connection with user check");
            builder.AddCheck<CacheHealthCheck>("Cache");

            // add your custom health checks here
            // builder.AddCheck<MyCustomHealthCheck>("my health check");

            return builder;
        }
    }
}
