using BridgeApiDemo.Services.Contracts;
using BridgeApiDemo.Services.Implementations.cs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddHttpClient(); 
builder.Services.AddScoped<IProxyService, ProxyService>();
builder.Services.AddScoped<IWeatherProxyService, WeatherProxyService>();
builder.Services.AddScoped<IJokeProxyService, JokeProxyService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
