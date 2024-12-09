using Blazor.Model;
using System.Collections.Generic;
using System.Linq;

namespace Blazor.Services
{
    public class InMemoryYearBookService : IYearBookService
    {
        private readonly List<YearBookEntry> _yearBookEntries;
        private int _nextId;

        public InMemoryYearBookService()
        {
            _yearBookEntries = new List<YearBookEntry>
            {
                new YearBookEntry(1, "Anna", "she/her", "Loves hiking", "https://media.istockphoto.com/id/1469154354/photo/portrait-of-laughing-beautiful-woman-touching-her-face.jpg?s=2048x2048&w=is&k=20&c=va9FZUX2rk2kqduj0Z5OKYXKjCEkUFZxOxEwQJ63vp8=", 2020),
                new YearBookEntry(2, "Sara", "she/her", "Fan of science fiction novels", "https://media.istockphoto.com/id/986564312/photo/first-rule-of-the-weekend-unwind.jpg?s=2048x2048&w=is&k=20&c=_h6T0sHNczz83vnRSI6_0aCfALNZmasHEO34_V5yeXM=", 2021),
                new YearBookEntry(3, "Oskar", "he/him", "Enjoys painting", "https://media.istockphoto.com/id/1550589735/photo/portrait-happy-or-confident-asian-man-with-arms-crossed-or-smile-in-studio-in-casual-fashion.jpg?s=2048x2048&w=is&k=20&c=zQWojgYFPUcYgz6czRNbvLilhvJ926Rwkwf4Tf8Nfw0=", 2010),
                new YearBookEntry(4, "Harry", "he/him", "Speaks 4 languages", "https://img.freepik.com/free-photo/man-glasses-orange-shirt-surprised-confused-standing-green-wall_141793-61019.jpg?size=626&ext=jpg", 2010),
                new YearBookEntry(5, "Hanna", "she/her", "Likes dancing", "https://img.freepik.com/free-photo/medium-shot-woman-wearing-headphones_23-2149818230.jpg?t=st=1731065514~exp=1731069114~hmac=31d5a63c2da1db5f317216fd9ba28500f293b1a7ebb31445b1f0ae6ccf4f138e&w=1060", 2015)
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
}