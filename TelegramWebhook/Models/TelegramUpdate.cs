namespace TelegramWebhook.Models
{
    public class TelegramUpdate
    {
        public Message Message { get; set; }
    }

    public class Message
    {
        public string Text { get; set; }
        public Chat Chat { get; set; }
    }

    public class Chat
    {
        public long Id { get; set; }
    }

}
