using Blazor.Model;

namespace Blazor.Services;

public interface IYearBookService
{
    List<YearBookEntry> getAllYearBookEntries();
    void AddYearBookEntry(YearBookEntry YearBookEntry);
}