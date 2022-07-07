using Ayandeh.Faraz.Dto;

namespace Ayandeh.Faraz.Organizations.Dto
{
    public class FindOrganizationUnitRolesInput : PagedAndFilteredInputDto
    {
        public long OrganizationUnitId { get; set; }
    }
}