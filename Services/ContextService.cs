using System;

namespace PresenceLayer.Services
{
    public class ContextService
    {
        public string GetCurrentDateTime()
        {
            return DateTime.Now.ToString("f");
        }
    }
}
