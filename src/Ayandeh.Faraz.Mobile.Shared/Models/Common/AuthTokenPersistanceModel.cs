using System;
using Abp.AutoMapper;
using Ayandeh.Faraz.Sessions.Dto;

namespace Ayandeh.Faraz.Models.Common
{
    [AutoMapFrom(typeof(ApplicationInfoDto)),
     AutoMapTo(typeof(ApplicationInfoDto))]
    public class ApplicationInfoPersistanceModel
    {
        public string Version { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}