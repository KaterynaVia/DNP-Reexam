using WebApi.Model;

namespace WebApi.Data;

public interface IMatchService
{
    public ICollection<Profile> Profiles { get; }

    public Task CreateProfile(Profile profile);
    public Task AddLikeToProfile(Like like, int profileId);
}