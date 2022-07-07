﻿using System.Collections.Generic;
using Ayandeh.Faraz.DynamicEntityProperties.Dto;

namespace Ayandeh.Faraz.Web.Areas.App.Models.DynamicProperty
{
    public class CreateOrEditDynamicPropertyViewModel
    {
        public DynamicPropertyDto DynamicPropertyDto { get; set; }

        public List<string> AllowedInputTypes { get; set; }
    }
}
