using System.Collections.Generic;
using Ayandeh.Faraz.Authorization.Permissions.Dto;

namespace Ayandeh.Faraz.Web.Areas.App.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}