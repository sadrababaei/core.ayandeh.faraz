using Microsoft.Extensions.Configuration;

namespace Ayandeh.Faraz.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
