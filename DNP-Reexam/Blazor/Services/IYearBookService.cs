using Blazor.Model;

namespace Blazor.Services;

public interface IYearBookService
{
    List<YearBookEntry> GetAllYearBookEntries();
    void AddYearBookEntry(YearBookEntry yearBookEntry);
}