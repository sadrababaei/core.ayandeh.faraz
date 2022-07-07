using System.Threading.Tasks;
using Ayandeh.Faraz.Security.Recaptcha;

namespace Ayandeh.Faraz.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
