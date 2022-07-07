using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Ayandeh.Faraz.EntityFrameworkCore;

namespace Ayandeh.Faraz.HealthChecks
{
    public class FarazDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public FarazDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("FarazDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("FarazDbContext could not connect to database"));
        }
    }
}
