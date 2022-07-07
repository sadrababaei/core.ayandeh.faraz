using Ayandeh.Faraz.Editions;
using Ayandeh.Faraz.Editions.Dto;
using Ayandeh.Faraz.MultiTenancy.Payments;
using Ayandeh.Faraz.Security;
using Ayandeh.Faraz.MultiTenancy.Payments.Dto;

namespace Ayandeh.Faraz.Web.Models.TenantRegistration
{
    public class TenantRegisterViewModel
    {
        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public int? EditionId { get; set; }

        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }
    }
}
