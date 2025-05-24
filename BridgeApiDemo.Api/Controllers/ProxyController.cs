using BridgeApiDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace BridgeApiDemo.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProxyController(IProxyService proxyService) : ControllerBase
{
    [HttpGet("post/{id}")]
    public async Task<IActionResult> GetPost(int id)
    {
        var result = await proxyService.GetPostAsync(id);
        if (result == null)
            return StatusCode(502, "Failed to fetch data from external API.");

        return Ok(result);
    }
}
