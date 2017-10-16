namespace Cenmetrix.Cemex.Message
{
    internal class Message
    {
        public string Body { get; set; }
        public string ToMail { get; set; }
        public string Subject { get; set; }
        public string AttachmentName { get; set; }
        public bool AddBCC { get; set; }
    }
}
