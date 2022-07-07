using Abp.AutoMapper;
using Ayandeh.Faraz.ApiClient;

namespace Ayandeh.Faraz.Models.Common
{
    [AutoMapFrom(typeof(TenantInformation)),
     AutoMapTo(typeof(TenantInformation))]
    public class TenantInformationPersistanceModel
    {
        public string TenancyName { get; set; }

        public int TenantId { get; set; }
    }
}