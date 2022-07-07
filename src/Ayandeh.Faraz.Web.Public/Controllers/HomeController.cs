using Microsoft.AspNetCore.Mvc;
using Ayandeh.Faraz.Web.Controllers;

namespace Ayandeh.Faraz.Web.Public.Controllers
{
    public class HomeController : FarazControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}