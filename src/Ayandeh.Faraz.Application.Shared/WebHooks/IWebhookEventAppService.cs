using System.Threading.Tasks;
using Abp.Webhooks;

namespace Ayandeh.Faraz.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
