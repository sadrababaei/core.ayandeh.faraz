using Abp.Events.Bus;

namespace Ayandeh.Faraz.MultiTenancy
{
    public class RecurringPaymentsEnabledEventData : EventData
    {
        public int TenantId { get; set; }
    }
}