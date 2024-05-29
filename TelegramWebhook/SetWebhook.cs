namespace TelegramWebhook
{
    public class SetWebhook
    {
        private static readonly string botToken = "UstozGitHubO`chirgizvordiTokenimi";
        private static readonly string webhookUrl = "https://localhost:7288/api/webhook"; // Замените на ваш реальный URL
        // https://localhost:7288/swagger/index.html
        static async Task Main(string[] args)
        {
            using var client = new HttpClient();
            var response = await client.GetAsync($"https://api.telegram.org/bot{botToken}/setWebhook?url={webhookUrl}");
            Console.WriteLine(await response.Content.ReadAsStringAsync());
        }
    }
}
