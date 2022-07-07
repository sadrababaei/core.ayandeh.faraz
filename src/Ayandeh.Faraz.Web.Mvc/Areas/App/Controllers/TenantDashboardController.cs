using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Ayandeh.Faraz.Authorization;
using Ayandeh.Faraz.DashboardCustomization;
using System.Threading.Tasks;
using Ayandeh.Faraz.Web.Areas.App.Startup;

namespace Ayandeh.Faraz.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize(AppPermissions.Pages_Tenant_Dashboard)]
    public class TenantDashboardController : CustomizableDashboardControllerBase
    {
        public TenantDashboardController(DashboardViewConfiguration dashboardViewConfiguration, 
            IDashboardCustomizationAppService dashboardCustomizationAppService) 
            : base(dashboardViewConfiguration, dashboardCustomizationAppService)
        {

        }

        public async Task<ActionResult> Index()
        {
            return await GetView(FarazDashboardCustomizationConsts.DashboardNames.DefaultTenantDashboard);
        }
    }
}