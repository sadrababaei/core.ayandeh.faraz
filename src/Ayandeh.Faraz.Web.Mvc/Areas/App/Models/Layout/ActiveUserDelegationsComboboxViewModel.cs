﻿using System.Collections.Generic;
using Ayandeh.Faraz.Authorization.Delegation;
using Ayandeh.Faraz.Authorization.Users.Delegation.Dto;

namespace Ayandeh.Faraz.Web.Areas.App.Models.Layout
{
    public class ActiveUserDelegationsComboboxViewModel
    {
        public IUserDelegationConfiguration UserDelegationConfiguration { get; set; }

        public List<UserDelegationDto> UserDelegations { get; set; }

        public string CssClass { get; set; }
    }
}
