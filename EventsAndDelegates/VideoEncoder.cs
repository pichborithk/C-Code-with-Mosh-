public class VideoEncoder
{
    // public delegate void VideoEncodedEventHandler(object source, EventArgs args);
    /*
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;
    */

    public event EventHandler<VideoEventArgs> VideoEncoded;

    public void Encode(Video video)
    {
        Console.WriteLine("Encoding Video...");
        Thread.Sleep(3000);

        // OnVideoEncoded();
        OnVideoEncoded(video);
    }

    // protected virtual void OnVideoEncoded() { 
    protected virtual void OnVideoEncoded(Video  video) {
        /*
                if (VideoEncoded != null)
                {
                    VideoEncoded(this, EventArgs.Empty);
                }
        */
        /*
                if (VideoEncoded != null)
                {
                    VideoEncoded(this, new VideoEventArgs() { Video = video });
                }
        */
        VideoEncoded?.Invoke(this, new VideoEventArgs() { Video = video });
    }
}

