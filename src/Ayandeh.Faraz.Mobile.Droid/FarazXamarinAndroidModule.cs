using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Ayandeh.Faraz
{
    [DependsOn(typeof(FarazXamarinSharedModule))]
    public class FarazXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FarazXamarinAndroidModule).GetAssembly());
        }
    }
}