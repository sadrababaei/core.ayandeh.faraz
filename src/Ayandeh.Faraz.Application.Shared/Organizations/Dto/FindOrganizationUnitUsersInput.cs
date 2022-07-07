using Ayandeh.Faraz.Dto;

namespace Ayandeh.Faraz.Organizations.Dto
{
    public class FindOrganizationUnitUsersInput : PagedAndFilteredInputDto
    {
        public long OrganizationUnitId { get; set; }
    }
}
