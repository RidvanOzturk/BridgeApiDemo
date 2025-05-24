using BridgeApiDemo.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BridgeApiDemo.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProxyController(IProxyService proxyService) : ControllerBase
{
    [HttpGet("{id}")]
    public async Task<IActionResult> GetData(int id)
    {
        var result = await proxyService.GetDataAsync(id);
        if (result == null)
            return StatusCode(502, "Failed to fetch data from external API.");

        return Ok(result);
    }
}
