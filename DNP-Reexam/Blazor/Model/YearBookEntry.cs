namespace Blazor.Model;

public class YearBookEntry
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Pronouns { get; set; }
    public string FunFact { get; set; }
    public string ImageUrl { get; set; }
    public DateTime StartedYear { get; set; }

    public YearBookEntry(int id, string name, string pronouns, string funFact, string imageUrl, DateTime startedYear)
    {
        Id = id;
        Name = name;
        Pronouns = pronouns;
        FunFact = funFact;
        ImageUrl = imageUrl;
        StartedYear = startedYear;
    }
    

    
}