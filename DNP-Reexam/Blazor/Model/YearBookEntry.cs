using System.ComponentModel.DataAnnotations;

namespace Blazor.Model;

public class YearBookEntry
{
    [Required]
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
    [MaxLength(100)]
    public string Pronouns { get; set; }
    public string FunFact { get; set; }
    [Required]
    public string ImageUrl { get; set; }
    [Range(1900, 2100)]
    public int StartedYear { get; set; }

    public YearBookEntry(int id, string name, string pronouns, string funFact, string imageUrl, int startedYear)
    {
        Id = id;
        Name = name;
        Pronouns = pronouns;
        FunFact = funFact;
        ImageUrl = imageUrl;
        StartedYear = startedYear;
    }
    

    
}