using Abp.AspNetCore.Mvc.ViewComponents;

namespace Ayandeh.Faraz.Web.Public.Views
{
    public abstract class FarazViewComponent : AbpViewComponent
    {
        protected FarazViewComponent()
        {
            LocalizationSourceName = FarazConsts.LocalizationSourceName;
        }
    }
}