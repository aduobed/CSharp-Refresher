public partial class Program
{
    class VideoEncoder
    {
        // 1. Define a delegate to holdor point to multiple methods
        // 2. Define an event based on that delegate
        // 3. Raise or invoke that event
        //public delegate void VideoEncodedEventHandler(object source, EventArgs e);

        public event EventHandler<VideoEventargs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video.......");
            Thread.Sleep(3000);

            OnVideoDecoded(video);
        }

        protected virtual void OnVideoDecoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventargs() { Video = video});
            }
        }
        
    }
}