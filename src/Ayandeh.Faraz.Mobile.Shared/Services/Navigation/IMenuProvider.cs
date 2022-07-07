using System.Collections.Generic;
using MvvmHelpers;
using Ayandeh.Faraz.Models.NavigationMenu;

namespace Ayandeh.Faraz.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}