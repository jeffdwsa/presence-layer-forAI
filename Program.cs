using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PresenceLayer.Services;
using PresenceLayer.Integrations;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registra LLMClient com HttpClient e ApiKey
builder.Services.AddHttpClient<LLMClient>();

builder.Services.AddSingleton(sp =>
{
    var httpClient = sp.GetRequiredService<HttpClient>();
    var apiKey = builder.Configuration["OpenAI:ApiKey"];
    return new LLMClient(httpClient, apiKey);
});

// Registra serviços da aplicação
builder.Services.AddSingleton<ContextService>();
builder.Services.AddSingleton<LocationService>();
builder.Services.AddSingleton<WeatherService>();
builder.Services.AddSingleton<HistoryService>();
builder.Services.AddSingleton<NewsService>();
builder.Services.AddSingleton<PromptAssembler>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();
