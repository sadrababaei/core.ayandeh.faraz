using System.ComponentModel.DataAnnotations;

namespace Ayandeh.Faraz.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}