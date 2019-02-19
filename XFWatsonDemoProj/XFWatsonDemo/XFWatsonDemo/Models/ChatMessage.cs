using System;

namespace XFWatsonDemo.Models
{
    public class ChatMessage
    {
        public string Text { get; set; }
        public DateTime MessageDateTime { get; set; }
        public bool IsIncoming { get; set; }

        public string Image { get; set; }

    }
}
