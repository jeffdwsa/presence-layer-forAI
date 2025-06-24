using System.Threading.Tasks;
using PresenceLayer.Models;

namespace PresenceLayer.Services
{
    public class LocationService
    {
        public async Task<LocationInfo> GetLocationAsync()
        {
            // TODO: implementar chamada real para localização via IP
            await Task.CompletedTask;
            return new LocationInfo
            {
                City = "Porto Alegre",
                Country = "Brazil"
            };
        }
    }
}
