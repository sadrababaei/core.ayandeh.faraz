using Abp.AutoMapper;
using Ayandeh.Faraz.MultiTenancy.Dto;

namespace Ayandeh.Faraz.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(EditionsSelectOutput))]
    public class EditionsSelectViewModel : EditionsSelectOutput
    {
    }
}
