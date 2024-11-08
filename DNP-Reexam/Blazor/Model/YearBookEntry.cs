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

    [Required]
    [Range(1900, 2100)]
    public int Year { get; set; }

    public YearBookEntry(int id, string name, string pronouns, string funFact, string imageUrl, int year)
    {
        Id = id;
        Name = name;
        Pronouns = pronouns;
        FunFact = funFact;
        ImageUrl = imageUrl;
        Year = year;
    }
}