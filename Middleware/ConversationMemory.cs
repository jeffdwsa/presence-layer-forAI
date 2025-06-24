using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace PresenceLayer.Middleware
{
    public class ConversationMemory
    {
        private readonly RequestDelegate _next;

        // Armazena hist�rico simples em mem�ria (pode ser substitu�do por cache distribu�do)
        private static readonly ConcurrentDictionary<string, string> _conversations = new();

        public ConversationMemory(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Exemplo: guardar algo no contexto para futuras requisi��es, como ID de conversa
            // Aqui poderia ser implementado para recuperar e salvar hist�rico de conversa

            await _next(context);
        }
    }
}
