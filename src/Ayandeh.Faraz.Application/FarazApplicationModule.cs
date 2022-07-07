using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Ayandeh.Faraz.Authorization;

namespace Ayandeh.Faraz
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(FarazApplicationSharedModule),
        typeof(FarazCoreModule)
        )]
    public class FarazApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FarazApplicationModule).GetAssembly());
        }
    }
}