using Ayandeh.Faraz.Dto;

namespace Ayandeh.Faraz.WebHooks.Dto
{
    public class GetAllSendAttemptsInput : PagedInputDto
    {
        public string SubscriptionId { get; set; }
    }
}
