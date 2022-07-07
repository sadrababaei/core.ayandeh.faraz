using System.Collections.Generic;
using Ayandeh.Faraz.Authorization.Users.Dto;
using Ayandeh.Faraz.Dto;

namespace Ayandeh.Faraz.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}