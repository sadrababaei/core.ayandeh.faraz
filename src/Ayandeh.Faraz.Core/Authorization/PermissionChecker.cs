using Abp.Authorization;
using Ayandeh.Faraz.Authorization.Roles;
using Ayandeh.Faraz.Authorization.Users;

namespace Ayandeh.Faraz.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
