using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Ayandeh.Faraz
{
    public class FarazCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FarazCoreSharedModule).GetAssembly());
        }
    }
}