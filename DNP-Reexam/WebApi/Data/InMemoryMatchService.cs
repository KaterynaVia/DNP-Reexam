using WebApi.Model;

namespace WebApi.Data;

public class InMemoryMatchService:IMatchService
{
    public ICollection<Profile> Profiles { get; set; }
    private int lastProfileId = 0;
    private int lastLikeId = 0;
    public Task CreateProfile(Profile profile)
    {
        profile.Id = ++lastProfileId;
        lastProfileId++;
        Profiles.Add(profile);
        return Task.CompletedTask;
    }
    public Task AddLikeToProfile(Like like, int profileId)
    {
        Profile? profile = Profiles.FirstOrDefault(p => p.Id == profileId);
        if (profile == null)
        {
            throw new Exception($"Profile with id {profileId} is not found");
        }
        like.Id = ++lastLikeId;
        lastLikeId++;
        profile.Likes.Add(like);
        return Task.CompletedTask;
    }
}