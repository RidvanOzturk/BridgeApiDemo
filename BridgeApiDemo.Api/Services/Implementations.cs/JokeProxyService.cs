using BridgeApiDemo.Services.Contracts;
using System.Net.Http;

namespace BridgeApiDemo.Services.Implementations.cs;

public class JokeProxyService(HttpClient httpClient) : IJokeProxyService
{
    public async Task<string> GetRandomJokeAsync()
    {
        var response = await httpClient.GetAsync("https://v2.jokeapi.dev/joke/Any");
        if (!response.IsSuccessStatusCode)
        {
            return null;
        }
        return await response.Content.ReadAsStringAsync();
    }
}
