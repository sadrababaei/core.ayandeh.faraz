using System.Collections.Generic;
using Ayandeh.Faraz.Editions;
using Ayandeh.Faraz.Editions.Dto;
using Ayandeh.Faraz.MultiTenancy.Payments;
using Ayandeh.Faraz.MultiTenancy.Payments.Dto;

namespace Ayandeh.Faraz.Web.Models.Payment
{
    public class BuyEditionViewModel
    {
        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}
