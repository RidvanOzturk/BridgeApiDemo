namespace BridgeApiDemo.Services.Contracts;

public interface IProxyService
{
    Task<object?> GetDataAsync(int id);
}
