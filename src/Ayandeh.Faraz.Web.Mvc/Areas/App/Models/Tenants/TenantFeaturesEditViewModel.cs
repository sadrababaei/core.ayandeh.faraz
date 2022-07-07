using Abp.AutoMapper;
using Ayandeh.Faraz.MultiTenancy;
using Ayandeh.Faraz.MultiTenancy.Dto;
using Ayandeh.Faraz.Web.Areas.App.Models.Common;

namespace Ayandeh.Faraz.Web.Areas.App.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }
    }
}