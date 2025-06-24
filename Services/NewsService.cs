using System.Collections.Generic;
using System.Threading.Tasks;
using PresenceLayer.Models;

namespace PresenceLayer.Services
{
    public class NewsService
    {
        public async Task<List<NewsItem>> GetTopNewsAsync()
        {
            // TODO: implementar integração com RSS ou API de notícias
            await Task.CompletedTask;
            return new List<NewsItem>
            {
                new NewsItem { Title = "Nenhuma notícia disponível no momento.", Url = "#" }
            };
        }
    }
}
