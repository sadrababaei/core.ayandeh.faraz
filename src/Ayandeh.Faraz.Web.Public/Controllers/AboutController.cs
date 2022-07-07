using Microsoft.AspNetCore.Mvc;
using Ayandeh.Faraz.Web.Controllers;

namespace Ayandeh.Faraz.Web.Public.Controllers
{
    public class AboutController : FarazControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}