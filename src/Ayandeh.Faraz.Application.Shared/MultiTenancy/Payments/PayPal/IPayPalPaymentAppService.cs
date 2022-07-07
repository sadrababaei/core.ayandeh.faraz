using System.Threading.Tasks;
using Abp.Application.Services;
using Ayandeh.Faraz.MultiTenancy.Payments.PayPal.Dto;

namespace Ayandeh.Faraz.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
