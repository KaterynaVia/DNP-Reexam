using Microsoft.AspNetCore.Mvc;
using WebApi.Data;

namespace WebApi.Controllers;

[Controller]
[Route("profiles")]

public class ProfileController:ControllerBase
{
    private  readonly IMatchService matchService;
    public ProfileController(IMatchService matchService)
    {
        this.matchService = matchService;
    }
    
}