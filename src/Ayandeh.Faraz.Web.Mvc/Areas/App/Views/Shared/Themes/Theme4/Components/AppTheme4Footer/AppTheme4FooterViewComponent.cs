using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ayandeh.Faraz.Web.Areas.App.Models.Layout;
using Ayandeh.Faraz.Web.Session;
using Ayandeh.Faraz.Web.Views;

namespace Ayandeh.Faraz.Web.Areas.App.Views.Shared.Themes.Theme4.Components.AppTheme4Footer
{
    public class AppTheme4FooterViewComponent : FarazViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppTheme4FooterViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerModel = new FooterViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(footerModel);
        }
    }
}
