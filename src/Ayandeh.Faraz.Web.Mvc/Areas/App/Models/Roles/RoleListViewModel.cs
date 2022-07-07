using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Ayandeh.Faraz.Authorization.Permissions.Dto;
using Ayandeh.Faraz.Web.Areas.App.Models.Common;

namespace Ayandeh.Faraz.Web.Areas.App.Models.Roles
{
    public class RoleListViewModel : IPermissionsEditViewModel
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}