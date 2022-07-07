using Abp.AspNetCore.Mvc.Authorization;
using Ayandeh.Faraz.Authorization;
using Ayandeh.Faraz.Storage;
using Abp.BackgroundJobs;

namespace Ayandeh.Faraz.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}