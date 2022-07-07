using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Ayandeh.Faraz.Web.Public.Views
{
    public abstract class FarazRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected FarazRazorPage()
        {
            LocalizationSourceName = FarazConsts.LocalizationSourceName;
        }
    }
}
