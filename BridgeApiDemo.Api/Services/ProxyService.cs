using System.Text.Json;

namespace BridgeApiDemo.Services;

public class ProxyService(HttpClient httpClient) : IProxyService
{

    public async Task<object?> GetPostAsync(int id)
    {
        var response = await httpClient.GetAsync($"https://jsonplaceholder.typicode.com/posts/{id}");
        if (!response.IsSuccessStatusCode)
            return null;

        var content = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<object>(content);
    }
}
