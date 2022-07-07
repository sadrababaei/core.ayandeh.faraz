using Microsoft.AspNetCore.Antiforgery;

namespace Ayandeh.Faraz.Web.Controllers
{
    public class AntiForgeryController : FarazControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
