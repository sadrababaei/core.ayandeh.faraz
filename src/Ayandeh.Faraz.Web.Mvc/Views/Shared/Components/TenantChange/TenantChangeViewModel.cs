using Abp.AutoMapper;
using Ayandeh.Faraz.Sessions.Dto;

namespace Ayandeh.Faraz.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}