using System;

namespace RealTime
{
    class Program
    {
        static void Main(string[] args)
        {
            MediaStorage m = new MediaStorage();
            AudioPlayer ap = new AudioPlayer();
            VideoPlayer vp = new VideoPlayer();
            MediaStorage.PlayerMedia playerDelegate = ap.PlayerAudioFile;
            m.ReportResult(playerDelegate, "mp3");
            playerDelegate += vp.PlayerVideoFile;
            m.ReportResult(playerDelegate, "mp4");
        }
    }
}
