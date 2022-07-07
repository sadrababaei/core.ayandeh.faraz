using Abp;

namespace Ayandeh.Faraz
{
    /// <summary>
    /// This class can be used as a base class for services in this application.
    /// It has some useful objects property-injected and has some basic methods most of services may need to.
    /// It's suitable for non domain nor application service classes.
    /// For domain services inherit <see cref="FarazDomainServiceBase"/>.
    /// For application services inherit FarazAppServiceBase.
    /// </summary>
    public abstract class FarazServiceBase : AbpServiceBase
    {
        protected FarazServiceBase()
        {
            LocalizationSourceName = FarazConsts.LocalizationSourceName;
        }
    }
}