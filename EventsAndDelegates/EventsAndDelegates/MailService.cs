public partial class Program
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventargs e)
        {
            Console.WriteLine("MailSerice: Sending an email....." + e.Video.Title);
        }
    }
}