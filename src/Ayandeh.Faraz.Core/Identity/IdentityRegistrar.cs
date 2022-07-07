using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Ayandeh.Faraz.Authentication.TwoFactor.Google;
using Ayandeh.Faraz.Authorization;
using Ayandeh.Faraz.Authorization.Roles;
using Ayandeh.Faraz.Authorization.Users;
using Ayandeh.Faraz.Editions;
using Ayandeh.Faraz.MultiTenancy;

namespace Ayandeh.Faraz.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>(options =>
                {
                    options.Tokens.ProviderMap[GoogleAuthenticatorProvider.Name] = new TokenProviderDescriptor(typeof(GoogleAuthenticatorProvider));
                })
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
