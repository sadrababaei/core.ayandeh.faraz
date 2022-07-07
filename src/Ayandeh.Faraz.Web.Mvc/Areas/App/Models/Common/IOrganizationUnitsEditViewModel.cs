using System.Collections.Generic;
using Ayandeh.Faraz.Organizations.Dto;

namespace Ayandeh.Faraz.Web.Areas.App.Models.Common
{
    public interface IOrganizationUnitsEditViewModel
    {
        List<OrganizationUnitDto> AllOrganizationUnits { get; set; }

        List<string> MemberedOrganizationUnits { get; set; }
    }
}