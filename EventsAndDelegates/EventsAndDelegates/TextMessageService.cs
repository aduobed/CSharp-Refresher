public partial class Program
{
    public class TextMessageService
    {
        public void OnVideoEncoded(object source, VideoEventargs e)
        {
            Console.WriteLine($"TextMessageService: Sending a text message..... {e.Video.Title}");
        }
    }
}