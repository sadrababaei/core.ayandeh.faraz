using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ayandeh.Faraz.Web.Areas.App.Models.Layout;
using Ayandeh.Faraz.Web.Views;

namespace Ayandeh.Faraz.Web.Areas.App.Views.Shared.Components.
    AppQuickThemeSelect
{
    public class AppQuickThemeSelectViewComponent : FarazViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(string cssClass, string iconClass = "flaticon-interface-7 fs-2")
        {
            return Task.FromResult<IViewComponentResult>(View(new QuickThemeSelectionViewModel
            {
                CssClass = cssClass,
                IconClass = iconClass
            }));
        }
    }
}
