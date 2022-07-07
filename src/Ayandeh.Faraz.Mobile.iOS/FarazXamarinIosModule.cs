using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Ayandeh.Faraz
{
    [DependsOn(typeof(FarazXamarinSharedModule))]
    public class FarazXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FarazXamarinIosModule).GetAssembly());
        }
    }
}