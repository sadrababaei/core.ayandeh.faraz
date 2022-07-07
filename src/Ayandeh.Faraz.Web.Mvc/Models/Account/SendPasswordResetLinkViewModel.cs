using System.ComponentModel.DataAnnotations;

namespace Ayandeh.Faraz.Web.Models.Account
{
    public class SendPasswordResetLinkViewModel
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}