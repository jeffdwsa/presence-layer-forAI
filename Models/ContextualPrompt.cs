using System.Collections.Generic;

namespace PresenceLayer.Models
{
    public class ContextualPrompt
    {
        public string DateTime { get; set; }
        public string Location { get; set; }
        public string Weather { get; set; }
        public List<string> History { get; set; }
        public List<string> News { get; set; }
        public string UserMessage { get; set; }
    }
}
