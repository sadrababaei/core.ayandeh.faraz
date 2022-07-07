using System.ComponentModel.DataAnnotations;

namespace Ayandeh.Faraz.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
