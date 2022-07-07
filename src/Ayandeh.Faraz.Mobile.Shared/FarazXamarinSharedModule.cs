using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Ayandeh.Faraz
{
    [DependsOn(typeof(FarazClientModule), typeof(AbpAutoMapperModule))]
    public class FarazXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FarazXamarinSharedModule).GetAssembly());
        }
    }
}