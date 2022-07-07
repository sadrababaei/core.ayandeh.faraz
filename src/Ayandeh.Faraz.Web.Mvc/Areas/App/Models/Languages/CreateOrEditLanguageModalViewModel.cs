using Abp.AutoMapper;
using Ayandeh.Faraz.Localization.Dto;

namespace Ayandeh.Faraz.Web.Areas.App.Models.Languages
{
    [AutoMapFrom(typeof(GetLanguageForEditOutput))]
    public class CreateOrEditLanguageModalViewModel : GetLanguageForEditOutput
    {
        public bool IsEditMode => Language.Id.HasValue;
    }
}