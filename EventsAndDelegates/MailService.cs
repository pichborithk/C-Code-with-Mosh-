﻿
public class MailService
{
    // public void OnVideoEncoded(object source, EventArgs args)
    public void OnVideoEncoded(object source, VideoEventArgs e)
    {
        Console.WriteLine("MailService: sending an email..." + e.Video.Title);
    }
}