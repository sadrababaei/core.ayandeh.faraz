using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Ayandeh.Faraz
{
    [DependsOn(typeof(FarazCoreSharedModule))]
    public class FarazApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FarazApplicationSharedModule).GetAssembly());
        }
    }
}