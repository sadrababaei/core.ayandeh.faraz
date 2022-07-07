using System.Collections.ObjectModel;

namespace Ayandeh.Faraz.Editions.Dto
{
	//Mapped in CustomDtoMapper
	public class LocalizableComboboxItemSourceDto
	{
		public Collection<LocalizableComboboxItemDto> Items { get; set; }
	}
}