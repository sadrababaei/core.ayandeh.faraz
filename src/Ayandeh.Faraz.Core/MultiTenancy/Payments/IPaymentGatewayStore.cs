using System.Collections.Generic;

namespace Ayandeh.Faraz.MultiTenancy.Payments
{
    public interface IPaymentGatewayStore
    {
        List<PaymentGatewayModel> GetActiveGateways();
    }
}
