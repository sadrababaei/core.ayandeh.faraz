using Abp.AspNetCore.Mvc.Views;

namespace Ayandeh.Faraz.Web.Views
{
    public abstract class FarazRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected FarazRazorPage()
        {
            LocalizationSourceName = FarazConsts.LocalizationSourceName;
        }
    }
}
