using System.Text;
using System.Threading.Tasks;
using PresenceLayer.Models;

namespace PresenceLayer.Services
{
    public class PromptAssembler
    {
        private readonly ContextService _contextService;
        private readonly LocationService _locationService;
        private readonly WeatherService _weatherService;
        private readonly HistoryService _historyService;
        private readonly NewsService _newsService;

        public PromptAssembler(
            ContextService contextService,
            LocationService locationService,
            WeatherService weatherService,
            HistoryService historyService,
            NewsService newsService)
        {
            _contextService = contextService;
            _locationService = locationService;
            _weatherService = weatherService;
            _historyService = historyService;
            _newsService = newsService;
        }

        public async Task<string> BuildPromptAsync(string userMessage)
        {
            var dateTime = _contextService.GetCurrentDateTime();
            var locationInfo = await _locationService.GetLocationAsync();
            var weatherInfo = await _weatherService.GetWeatherAsync($"{locationInfo.City}, {locationInfo.Country}");
            var history = _historyService.GetLastMessages(3);
            var newsItems = await _newsService.GetTopNewsAsync();

            var sb = new StringBuilder();

            sb.AppendLine($"🕒 Data e hora: {dateTime}");
            sb.AppendLine($"📍 Local: {locationInfo.City}, {locationInfo.Country}");
            sb.AppendLine($"🌤️ Clima: {weatherInfo.Temperature}, {weatherInfo.Description}");
            sb.AppendLine();
            sb.AppendLine("🧠 Últimos tópicos:");
            foreach (var msg in history)
                sb.AppendLine($"- {msg}");
            sb.AppendLine();
            sb.AppendLine("📰 Últimas notícias:");
            foreach (var news in newsItems)
                sb.AppendLine($"- {news.Title} ({news.Url})");
            sb.AppendLine();
            sb.AppendLine("💬 Pergunta do usuário:");
            sb.AppendLine($"\"{userMessage}\"");

            return sb.ToString();
        }
    }
}
