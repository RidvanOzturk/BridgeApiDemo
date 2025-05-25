using BridgeApiDemo.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BridgeApiDemo.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WeatherController(IWeatherProxyService weatherProxyService) : ControllerBase
{
    [HttpGet("{city}")]
    public async Task<IActionResult> GetWeather(string city)
    {
        var result = await weatherProxyService.GetWeatherByCityAsync(city);
        return Content(result, "application/json");
    }
}
