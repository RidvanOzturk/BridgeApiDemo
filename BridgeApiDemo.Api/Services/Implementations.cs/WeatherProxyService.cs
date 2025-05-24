
using BridgeApiDemo.Services.Contracts;
using System.Net.Http;

namespace BridgeApiDemo.Services.Implementations.cs;

public class WeatherProxyService : IWeatherProxyService
{
    private readonly HttpClient _httpClient;
    private const string ApiKey = "YOUR_API_KEY";

    public WeatherProxyService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> GetWeatherByCityAsync(string city)
    {
        var url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={ApiKey}&units=metric";
        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }
}

