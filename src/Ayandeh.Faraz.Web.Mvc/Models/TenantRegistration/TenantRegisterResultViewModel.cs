using Abp.AutoMapper;
using Ayandeh.Faraz.MultiTenancy.Dto;

namespace Ayandeh.Faraz.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(RegisterTenantOutput))]
    public class TenantRegisterResultViewModel : RegisterTenantOutput
    {
        public string TenantLoginAddress { get; set; }
    }
}