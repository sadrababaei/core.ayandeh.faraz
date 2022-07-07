using Abp.Domain.Services;

namespace Ayandeh.Faraz
{
    public abstract class FarazDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected FarazDomainServiceBase()
        {
            LocalizationSourceName = FarazConsts.LocalizationSourceName;
        }
    }
}
