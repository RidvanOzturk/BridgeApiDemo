namespace BridgeApiDemo.Services.Contracts;

public interface IJokeProxyService
{
    Task<string> GetRandomJokeAsync();
}
