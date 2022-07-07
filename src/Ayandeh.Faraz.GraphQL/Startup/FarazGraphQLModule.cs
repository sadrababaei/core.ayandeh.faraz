using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Ayandeh.Faraz.Startup
{
    [DependsOn(typeof(FarazCoreModule))]
    public class FarazGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FarazGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}