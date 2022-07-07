using System.Threading.Tasks;
using Abp.Application.Services;

namespace Ayandeh.Faraz.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
