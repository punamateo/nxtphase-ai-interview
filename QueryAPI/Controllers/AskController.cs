using Microsoft.AspNetCore.Mvc;
using QueryAPI.Models;
using QueryAPI.Services;
using System.Threading.Tasks;

namespace QueryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AskController : ControllerBase
    {
        private readonly ILlmService _llmService;

        public AskController(ILlmService llmService)
        {
            _llmService = llmService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] QueryRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Query))
                return BadRequest("La query no puede estar vacía.");

            var response = await _llmService.GenerateResponseAsync(request.Query);

            return Ok(new { Response = response, Cached = false });
        }
    }
}
