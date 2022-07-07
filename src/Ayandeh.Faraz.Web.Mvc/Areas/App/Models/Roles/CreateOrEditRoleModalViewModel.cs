using Abp.AutoMapper;
using Ayandeh.Faraz.Authorization.Roles.Dto;
using Ayandeh.Faraz.Web.Areas.App.Models.Common;

namespace Ayandeh.Faraz.Web.Areas.App.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class CreateOrEditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool IsEditMode => Role.Id.HasValue;
    }
}