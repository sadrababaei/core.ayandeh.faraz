using System.Threading.Tasks;

namespace Ayandeh.Faraz.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}