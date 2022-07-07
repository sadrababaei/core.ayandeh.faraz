using Abp.AutoMapper;
using Ayandeh.Faraz.Authorization.Users;
using Ayandeh.Faraz.Authorization.Users.Dto;
using Ayandeh.Faraz.Web.Areas.App.Models.Common;

namespace Ayandeh.Faraz.Web.Areas.App.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; set; }
    }
}