using System.Threading.Tasks;
using Abp.Application.Services;
using Ayandeh.Faraz.MultiTenancy.Payments.Dto;
using Ayandeh.Faraz.MultiTenancy.Payments.Stripe.Dto;

namespace Ayandeh.Faraz.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}