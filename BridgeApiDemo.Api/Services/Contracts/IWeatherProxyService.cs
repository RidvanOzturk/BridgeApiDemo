namespace BridgeApiDemo.Services.Contracts;

public interface IWeatherProxyService
{
    Task<string> GetWeatherByCityAsync(string city);
}
