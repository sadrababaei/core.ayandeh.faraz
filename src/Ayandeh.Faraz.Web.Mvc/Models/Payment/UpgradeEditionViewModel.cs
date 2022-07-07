using System.Collections.Generic;
using Ayandeh.Faraz.Editions.Dto;
using Ayandeh.Faraz.MultiTenancy.Payments;

namespace Ayandeh.Faraz.Web.Models.Payment
{
    public class UpgradeEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public PaymentPeriodType PaymentPeriodType { get; set; }

        public SubscriptionPaymentType SubscriptionPaymentType { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}