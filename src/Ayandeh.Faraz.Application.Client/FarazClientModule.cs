using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Ayandeh.Faraz
{
    public class FarazClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FarazClientModule).GetAssembly());
        }
    }
}
