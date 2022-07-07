using Abp.Application.Services.Dto;
using Abp.Webhooks;
using Ayandeh.Faraz.WebHooks.Dto;

namespace Ayandeh.Faraz.Web.Areas.App.Models.Webhooks
{
    public class CreateOrEditWebhookSubscriptionViewModel
    {
        public WebhookSubscription WebhookSubscription { get; set; }

        public ListResultDto<GetAllAvailableWebhooksOutput> AvailableWebhookEvents { get; set; }
    }
}
