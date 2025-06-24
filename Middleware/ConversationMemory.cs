using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace PresenceLayer.Middleware
{
    public class ConversationMemory
    {
        private readonly RequestDelegate _next;

        // Armazena histórico simples em memória (pode ser substituído por cache distribuído)
        private static readonly ConcurrentDictionary<string, string> _conversations = new();

        public ConversationMemory(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Exemplo: guardar algo no contexto para futuras requisições, como ID de conversa
            // Aqui poderia ser implementado para recuperar e salvar histórico de conversa

            await _next(context);
        }
    }
}
