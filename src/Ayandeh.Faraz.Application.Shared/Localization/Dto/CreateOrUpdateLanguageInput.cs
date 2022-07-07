﻿using System.ComponentModel.DataAnnotations;

namespace Ayandeh.Faraz.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}