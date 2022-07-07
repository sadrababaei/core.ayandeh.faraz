using Abp.Dependency;
using Ayandeh.Faraz.Configuration;
using Ayandeh.Faraz.Url;
using Ayandeh.Faraz.Web.Url;

namespace Ayandeh.Faraz.Web.Public.Url
{
    public class WebUrlService : WebUrlServiceBase, IWebUrlService, ITransientDependency
    {
        public WebUrlService(
            IAppConfigurationAccessor appConfigurationAccessor) :
            base(appConfigurationAccessor)
        {
        }

        public override string WebSiteRootAddressFormatKey => "App:WebSiteRootAddress";

        public override string ServerRootAddressFormatKey => "App:AdminWebSiteRootAddress";
    }
}