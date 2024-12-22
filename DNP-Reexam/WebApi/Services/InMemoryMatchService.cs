using WebApi.Model;


namespace WebApi.Services;

public class InMemoryMatchService : IMatchService
{
    private readonly List<Profile> _profiles = new List<Profile>

    {
            new Profile
            {
                Id = 1,
                Name = "Alice",
                Age = 25,
                Gender = "Female",
                Likes = new List<Like> { new Like { LikedProfileId = 2 } }
            },
            new Profile
            {
                Id = 2,
                Name = "Bob",
                Age = 30,
                Gender = "Male",
                Likes = new List<Like> { new Like { LikedProfileId = 1 }, new Like { LikedProfileId = 3 } }
            },
            new Profile
            {
                Id = 3,
                Name = "Charlie",
                Age = 28,
                Gender = "Non-binary",
                Likes = new List<Like> { new Like { LikedProfileId = 1 } }
            }
        };
public async Task AddProfile(Profile profile)
{
    profile.Id = _profiles.Count + 1;
    _profiles.Add(profile);
    await Task.CompletedTask;
}

public async Task AddLikeToProfile(Like like, int profileId)
{
    var profile = _profiles.FirstOrDefault(p => p.Id == profileId);
    if (profile == null)
    {
        throw new KeyNotFoundException($"Profile with ID {profileId} not found.");
    }

    profile.Likes.Add(like);
    await Task.CompletedTask;
}
public ICollection<Profile> GetProfiles(string gender = null, int? minAge = null, int? maxAge = null)
{
    var query = _profiles.AsQueryable();

    if (!string.IsNullOrEmpty(gender))
    {
        query = query.Where(p => p.Gender.Equals(gender, StringComparison.OrdinalIgnoreCase));
    }
    if (minAge.HasValue)
    {
        query = query.Where(p => p.Age >= minAge.Value);
    }
    if (maxAge.HasValue)
    {
        query = query.Where(p => p.Age <= maxAge.Value);
    }

    return query.ToList();
}

public ICollection<Profile> GetMatches(int profileId)
{
    var profile = _profiles.FirstOrDefault(p => p.Id == profileId);
    if (profile == null)
    {
        throw new KeyNotFoundException($"Profile with ID {profileId} not found.");
    }

    var matches = profile.Likes
        .Where(like => _profiles.Any(p => p.Id == like.LikedProfileId && p.Likes.Any(l => l.LikedProfileId == profileId)))
        .Select(like => _profiles.First(p => p.Id == like.LikedProfileId))
        .ToList();

    return matches;
}

}