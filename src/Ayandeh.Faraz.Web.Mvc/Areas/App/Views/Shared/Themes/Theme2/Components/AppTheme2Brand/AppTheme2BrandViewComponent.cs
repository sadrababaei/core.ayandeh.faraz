using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ayandeh.Faraz.Web.Areas.App.Models.Layout;
using Ayandeh.Faraz.Web.Session;
using Ayandeh.Faraz.Web.Views;

namespace Ayandeh.Faraz.Web.Areas.App.Views.Shared.Themes.Theme2.Components.AppTheme2Brand
{
    public class AppTheme2BrandViewComponent : FarazViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppTheme2BrandViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var headerModel = new HeaderViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(headerModel);
        }
    }
}
