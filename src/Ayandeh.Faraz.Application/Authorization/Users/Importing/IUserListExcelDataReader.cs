using System.Collections.Generic;
using Ayandeh.Faraz.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace Ayandeh.Faraz.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
