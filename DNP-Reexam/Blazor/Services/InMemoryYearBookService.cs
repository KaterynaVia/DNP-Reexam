using Blazor.Model;

namespace Blazor.Services;

public class InMemoryYearBookService:IYearBookService
{
    private List<YearBookEntry> _yearBookEntries;
    private int _nextId = 1;

    public InMemoryYearBookService()
    {
        _yearBookEntries = new List<YearBookEntry>()
        {
            new YearBookEntry(1, "Harry", "he", "true", "image.jpg", DateTime.Now.AddDays(-1)),
            new YearBookEntry(2, "Harry2", "he", "true", "image.jpg", DateTime.Now.AddDays(-1)),
            new YearBookEntry(3, "Harry3", "he", "true", "image.jpg", DateTime.Now.AddDays(-1)),
            new YearBookEntry(4, "Harry4", "he", "true", "image.jpg", DateTime.Now.AddDays(-1)),
            new YearBookEntry(5, "Harry5", "he", "true", "image.jpg", DateTime.Now.AddDays(-1)),
        };
        _nextId = _yearBookEntries.Max(d => d.Id) + 1;
    }
   

    

    public List<YearBookEntry> getAllYearBookEntries()
    {
        return _yearBookEntries.OrderBy(d => d.StartedYear).ToList();
    }

    public void AddYearBookEntry(YearBookEntry yearBookEntry)
    {
        yearBookEntry.Id = _nextId++;
        yearBookEntry.StartedYear = DateTime.Now;
        _yearBookEntries.Add(yearBookEntry);
    }
}