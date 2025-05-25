
using BridgeApiDemo.Services.Contracts;
using System.Net.Http;

namespace BridgeApiDemo.Services.Implementations.cs;

public class WeatherProxyService(HttpClient httpClient) : IWeatherProxyService
{
    private const string ApiKey = "demoapi123";

  

    public async Task<string> GetWeatherByCityAsync(string city)
    {
        var url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={ApiKey}&units=metric";
        var response = await httpClient.GetAsync(url);
        if (!response.IsSuccessStatusCode)
        {
            return null;
        }
        return await response.Content.ReadAsStringAsync();
    }
}

