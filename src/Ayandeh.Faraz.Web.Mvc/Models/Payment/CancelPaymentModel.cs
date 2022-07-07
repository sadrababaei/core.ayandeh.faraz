using Ayandeh.Faraz.MultiTenancy.Payments;

namespace Ayandeh.Faraz.Web.Models.Payment
{
    public class CancelPaymentModel
    {
        public string PaymentId { get; set; }

        public SubscriptionPaymentGatewayType Gateway { get; set; }
    }
}