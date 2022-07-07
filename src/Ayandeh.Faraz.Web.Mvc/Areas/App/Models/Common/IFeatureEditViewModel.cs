using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Ayandeh.Faraz.Editions.Dto;

namespace Ayandeh.Faraz.Web.Areas.App.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}