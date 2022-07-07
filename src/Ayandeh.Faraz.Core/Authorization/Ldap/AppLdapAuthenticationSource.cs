using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using Ayandeh.Faraz.Authorization.Users;
using Ayandeh.Faraz.MultiTenancy;

namespace Ayandeh.Faraz.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}