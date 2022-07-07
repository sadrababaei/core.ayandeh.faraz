using System.Collections.Generic;
using Ayandeh.Faraz.Auditing.Dto;
using Ayandeh.Faraz.Dto;

namespace Ayandeh.Faraz.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
