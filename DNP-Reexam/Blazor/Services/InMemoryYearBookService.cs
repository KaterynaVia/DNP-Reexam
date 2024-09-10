using Blazor.Model;

namespace Blazor.Services;

public class InMemoryYearBookService:IYearBookService
{
    private readonly List<YearBookEntry> _yearBookEntries;
    private int _nextId;

    public InMemoryYearBookService()
    {
        _yearBookEntries = new List<YearBookEntry>()
        {
            new YearBookEntry(1, "Harry", "he", "Loves hiking", "https://img.freepik.com/free-photo/happy-nice-dark-skinned-girl-perfect-smile_176420-35297.jpg?size=626&ext=jpg\n", 2020),
            new YearBookEntry(2, "Harry2", "he", "Fan of science fiction novels", "https://img.freepik.com/free-photo/man-glasses-orange-shirt-surprised-confused-standing-green-wall_141793-61019.jpg?size=626&ext=jpg", 2021),
            new YearBookEntry(3, "Harry3", "he", "Enjoys painting", "https://img.freepik.com/free-photo/man-glasses-orange-shirt-surprised-confused-standing-green-wall_141793-61019.jpg?size=626&ext=jpg", 2010),
            new YearBookEntry(4, "Harry4", "he", "Speaks 4 languagese", "https://img.freepik.com/free-photo/man-glasses-orange-shirt-surprised-confused-standing-green-wall_141793-61019.jpg?size=626&ext=jpg", 2018),
            new YearBookEntry(5, "Harry5", "he", "Likes dancing", "https://img.freepik.com/free-photo/medium-shot-woman-wearing-headphones_23-2149818230.jpg?t=st=1731065514~exp=1731069114~hmac=31d5a63c2da1db5f317216fd9ba28500f293b1a7ebb31445b1f0ae6ccf4f138e&w=1060", 2015),
        };
        _nextId = _yearBookEntries.Max(d => d.Id) + 1;
    }
   

    

    public List<YearBookEntry> GetAllYearBookEntries()
    {
        return _yearBookEntries.OrderBy(d => d.Year).ToList();
    }

    public void AddYearBookEntry(YearBookEntry yearBookEntry)
    {
        yearBookEntry.Id = _nextId++;
        _yearBookEntries.Add(yearBookEntry);
    }
}