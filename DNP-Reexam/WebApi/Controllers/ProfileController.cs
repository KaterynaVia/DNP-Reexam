using Microsoft.AspNetCore.Mvc;
using WebApi.Model;
using WebApi.Services;

namespace WebApi.Controllers;

[Controller]
[Route("profiles")]

public class ProfileController:ControllerBase
{
    private  readonly IMatchService _matchService;
    public ProfileController(IMatchService matchService)
    {
        _matchService = matchService;
    }
    [HttpPost]
    [Route("create")]
    public async Task<IActionResult> CreateProfile([FromBody] Profile profile)
    {
        if (string.IsNullOrWhiteSpace(profile.Name) || profile.Age <= 0 || string.IsNullOrWhiteSpace(profile.Gender))
        {
            return BadRequest("All profile properties must have valid values.");
        }

        await _matchService.AddProfile(profile);
        return Ok(profile);
    }

    // 2.4.3 Add Like
    [HttpPost]
    [Route("{profileId}/like")]
    public async Task<IActionResult> AddLike(int profileId, [FromBody] Like like)
    {
        var profiles = _matchService.GetProfiles();
        if (!profiles.Any(p => p.Id == like.LikedProfileId))
        {
            return BadRequest("Liked profile does not exist.");
        }

        await _matchService.AddLikeToProfile(like, profileId);
        return Ok();
    }

    // 2.4.4 View All Profiles
    [HttpGet]
    public IActionResult GetProfiles([FromQuery] string gender, [FromQuery] int? minAge, [FromQuery] int? maxAge)
    {
        var profiles = _matchService.GetProfiles(gender, minAge, maxAge);
        return Ok(profiles);
    }

    // 2.4.5 View Matches
    [HttpGet]
    [Route("{profileId}/matches")]
    public IActionResult GetMatches(int profileId)
    {
        try
        {
            var matches = _matchService.GetMatches(profileId);
            return Ok(matches);
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(ex.Message);
        }
    }
}