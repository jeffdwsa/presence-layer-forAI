using Microsoft.AspNetCore.Mvc;
using PresenceLayer.Services;
using PresenceLayer.Integrations;  
using System.Threading.Tasks;


namespace PresenceLayer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PromptController : ControllerBase
    {
        private readonly PromptAssembler _promptAssembler;
        private readonly LLMClient _llmClient;

        public PromptController(PromptAssembler promptAssembler, LLMClient llmClient)
        {
            _promptAssembler = promptAssembler;
            _llmClient = llmClient;
        }

        [HttpPost]
        public async Task<IActionResult> GeneratePrompt([FromBody] UserMessageRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.UserMessage))
                return BadRequest("A mensagem do usu�rio n�o pode ser vazia.");

            var prompt = await _promptAssembler.BuildPromptAsync(request.UserMessage);

            return Ok(new { contextualPrompt = prompt });
        }

        // Modelo para receber a mensagem do usu�rio no corpo da requisi��o
        public class UserMessageRequest
        {
            public string UserMessage { get; set; }
        }
    } 
} 
