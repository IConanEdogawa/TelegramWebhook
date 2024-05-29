using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using TelegramWebhook.Models;


namespace TelegramWebhook.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class WebhookController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private readonly string _botToken = "YOUR_BOT_TOKEN";

        public WebhookController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TelegramUpdate update)
        {
            if (update?.Message?.Text != null)
            {
                var responseMessage = $"You said: {update.Message.Text}";
                var chatId = update.Message.Chat.Id;
                var response = await _httpClient.GetAsync(
                    $"https://api.telegram.org/bot{_botToken}/sendMessage?chat_id={chatId}&text={responseMessage}");
                return Ok();
            }
            return BadRequest();
        }
    }

}
