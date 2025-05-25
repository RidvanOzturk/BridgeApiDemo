using BridgeApiDemo.Services.Contracts;
using BridgeApiDemo.Services.Implementations.cs;
using Microsoft.AspNetCore.Mvc;

namespace BridgeApiDemo.Controllers;

[Route("api/[controller]")]
[ApiController]
public class JokeController(IJokeProxyService jokeProxyService) : ControllerBase
{
    [HttpGet("random")]
    public async Task<IActionResult> GetJoke()
    {
        var result = await jokeProxyService.GetRandomJokeAsync();
        return Content(result, "application/json");
    }
}
