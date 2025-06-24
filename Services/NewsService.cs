using System.Collections.Generic;
using System.Threading.Tasks;
using PresenceLayer.Models;

namespace PresenceLayer.Services
{
    public class NewsService
    {
        public async Task<List<NewsItem>> GetTopNewsAsync()
        {
            // TODO: implementar integra��o com RSS ou API de not�cias
            await Task.CompletedTask;
            return new List<NewsItem>
            {
                new NewsItem { Title = "Nenhuma not�cia dispon�vel no momento.", Url = "#" }
            };
        }
    }
}
