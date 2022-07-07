using System.Threading.Tasks;
using Abp.Authorization.Users;
using Ayandeh.Faraz.Authorization.Users;

namespace Ayandeh.Faraz.Authorization
{
    public static class UserManagerExtensions
    {
        public static async Task<User> GetAdminAsync(this UserManager userManager)
        {
            return await userManager.FindByNameAsync(AbpUserBase.AdminUserName);
        }
    }
}
