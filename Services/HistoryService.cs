using System.Collections.Generic;
using System.Linq;

namespace PresenceLayer.Services
{
    public class HistoryService
    {
        private readonly List<string> _history = new();

        public void AddMessage(string message)
        {
            _history.Add(message);
            if (_history.Count > 5)
                _history.RemoveAt(0);
        }

        public List<string> GetLastMessages(int count)
        {
            return _history.TakeLast(count).ToList();
        }
    }
}
