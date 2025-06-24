using System.Threading.Tasks;
using PresenceLayer.Models;

namespace PresenceLayer.Services
{
    public class WeatherService
    {
        public async Task<WeatherInfo> GetWeatherAsync(string location)
        {
            // TODO: implementar chamada real para API de clima
            await Task.CompletedTask;
            return new WeatherInfo
            {
                Temperature = "26°C",
                Description = "céu limpo"
            };
        }
    }
}
