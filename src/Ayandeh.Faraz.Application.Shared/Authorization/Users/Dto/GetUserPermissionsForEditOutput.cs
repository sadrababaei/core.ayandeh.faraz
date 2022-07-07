using System.Collections.Generic;
using Ayandeh.Faraz.Authorization.Permissions.Dto;

namespace Ayandeh.Faraz.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}