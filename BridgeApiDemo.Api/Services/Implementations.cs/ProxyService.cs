using BridgeApiDemo.Services.Contracts;
using System.Text.Json;

namespace BridgeApiDemo.Services.Implementations.cs;

public class ProxyService(HttpClient httpClient) : IProxyService
{

    public async Task<object?> GetDataAsync(int id)
    {
        var response = await httpClient.GetAsync($"https://jsonplaceholder.typicode.com/posts/{id}");
        if (!response.IsSuccessStatusCode)
        {
            return null;
        }
        var content = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<object>(content);
    }
}
