using System.Collections.Generic;
using Abp;
using Ayandeh.Faraz.Chat.Dto;
using Ayandeh.Faraz.Dto;

namespace Ayandeh.Faraz.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
