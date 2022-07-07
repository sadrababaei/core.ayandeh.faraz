using Abp.Auditing;
using Ayandeh.Faraz.Configuration.Dto;

namespace Ayandeh.Faraz.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}