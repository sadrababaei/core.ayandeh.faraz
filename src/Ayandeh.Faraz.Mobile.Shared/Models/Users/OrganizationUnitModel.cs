using Abp.AutoMapper;
using Ayandeh.Faraz.Organizations.Dto;

namespace Ayandeh.Faraz.Models.Users
{
    [AutoMapFrom(typeof(OrganizationUnitDto))]
    public class OrganizationUnitModel : OrganizationUnitDto
    {
        public bool IsAssigned { get; set; }
    }
}