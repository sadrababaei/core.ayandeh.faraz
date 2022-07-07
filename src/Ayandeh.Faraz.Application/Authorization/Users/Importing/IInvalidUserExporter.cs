using System.Collections.Generic;
using Ayandeh.Faraz.Authorization.Users.Importing.Dto;
using Ayandeh.Faraz.Dto;

namespace Ayandeh.Faraz.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
