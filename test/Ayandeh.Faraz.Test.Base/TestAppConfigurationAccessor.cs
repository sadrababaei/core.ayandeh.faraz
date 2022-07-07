using Abp.Dependency;
using Abp.Reflection.Extensions;
using Microsoft.Extensions.Configuration;
using Ayandeh.Faraz.Configuration;

namespace Ayandeh.Faraz.Test.Base
{
    public class TestAppConfigurationAccessor : IAppConfigurationAccessor, ISingletonDependency
    {
        public IConfigurationRoot Configuration { get; }

        public TestAppConfigurationAccessor()
        {
            Configuration = AppConfigurations.Get(
                typeof(FarazTestBaseModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }
    }
}
