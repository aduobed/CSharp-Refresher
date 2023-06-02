public partial class Program
{

static void Main(string[] args)
{
        var video = new Video() { Title = "Video 1"};
        var videoEncoder = new VideoEncoder(); //publisher
        var mailService = new MailService(); //subscriber
        var textMessageService = new TextMessageService();

        videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
        videoEncoder.VideoEncoded += textMessageService.OnVideoEncoded;

        videoEncoder.Encode(video);
}
}