namespace BridgeApiDemo.Services;

public interface IProxyService
{
    Task<object?> GetPostAsync(int id);
}
