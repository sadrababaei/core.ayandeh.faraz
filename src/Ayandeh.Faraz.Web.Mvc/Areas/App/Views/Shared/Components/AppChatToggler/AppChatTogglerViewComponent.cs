using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ayandeh.Faraz.Web.Areas.App.Models.Layout;
using Ayandeh.Faraz.Web.Views;

namespace Ayandeh.Faraz.Web.Areas.App.Views.Shared.Components.AppChatToggler
{
    public class AppChatTogglerViewComponent : FarazViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(string cssClass, string iconClass = "flaticon-chat-2 fs-2")
        {
            return Task.FromResult<IViewComponentResult>(View(new ChatTogglerViewModel
            {
                CssClass = cssClass,
                IconClass = iconClass
            }));
        }
    }
}
