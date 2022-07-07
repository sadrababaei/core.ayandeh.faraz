using System.Collections.Generic;
using Ayandeh.Faraz.Authorization.Permissions.Dto;

namespace Ayandeh.Faraz.Authorization.Roles.Dto
{
    public class GetRoleForEditOutput
    {
        public RoleEditDto Role { get; set; }

        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}