using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Ayandeh.Faraz.Configure;
using Ayandeh.Faraz.Startup;
using Ayandeh.Faraz.Test.Base;

namespace Ayandeh.Faraz.GraphQL.Tests
{
    [DependsOn(
        typeof(FarazGraphQLModule),
        typeof(FarazTestBaseModule))]
    public class FarazGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FarazGraphQLTestModule).GetAssembly());
        }
    }
}