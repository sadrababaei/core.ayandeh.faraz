using System.Threading.Tasks;
using Ayandeh.Faraz.Authorization.Users;

namespace Ayandeh.Faraz.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
