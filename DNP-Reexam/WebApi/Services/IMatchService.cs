using WebApi.Model;

namespace WebApi.Services;

public interface IMatchService
{

   // public ICollection<Profile> GetProfiles();

    public Task AddProfile(Profile profile);
    public Task AddLikeToProfile(Like like, int profileId);
    ICollection<Profile> GetProfiles(string gender = null, int? minAge = null, int? maxAge = null); 
    ICollection<Profile> GetMatches(int profileId); 
}