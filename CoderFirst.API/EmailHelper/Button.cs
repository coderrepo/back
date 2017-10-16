namespace Cenmetrix.Cemex.Message
{
    public enum ButtonType
    {
        Accept,
        Reject,
    }
    public class Button
    {
        public string Title { get; set; }
        public ButtonType Type { get; set; }
        public string Url { get; set; }
    }
}
