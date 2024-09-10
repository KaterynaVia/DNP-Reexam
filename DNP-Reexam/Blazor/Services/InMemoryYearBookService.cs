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
            new YearBookEntry(1, "Harry", "he", "true", "https://img.freepik.com/free-photo/man-glasses-orange-shirt-surprised-confused-standing-green-wall_141793-61019.jpg?size=626&ext=jpg", 2020),
            new YearBookEntry(2, "Harry2", "he", "true", "https://img.freepik.com/free-photo/man-glasses-orange-shirt-surprised-confused-standing-green-wall_141793-61019.jpg?size=626&ext=jpg", 2021),
            new YearBookEntry(3, "Harry3", "he", "true", "https://img.freepik.com/free-photo/man-glasses-orange-shirt-surprised-confused-standing-green-wall_141793-61019.jpg?size=626&ext=jpg", 2010),
            new YearBookEntry(4, "Harry4", "he", "true", "https://img.freepik.com/free-photo/man-glasses-orange-shirt-surprised-confused-standing-green-wall_141793-61019.jpg?size=626&ext=jpg", 2018),
            new YearBookEntry(5, "Harry5", "he", "true", "https://img.freepik.com/free-photo/man-glasses-orange-shirt-surprised-confused-standing-green-wall_141793-61019.jpg?size=626&ext=jpg", 2015),
        };
        _nextId = _yearBookEntries.Max(d => d.Id) + 1;
    }
   

    

    public List<YearBookEntry> GetAllYearBookEntries()
    {
        return _yearBookEntries.OrderBy(d => d.StartedYear).ToList();
    }

    public void AddYearBookEntry(YearBookEntry yearBookEntry)
    {
        yearBookEntry.Id = _nextId++;
        _yearBookEntries.Add(yearBookEntry);
    }
}