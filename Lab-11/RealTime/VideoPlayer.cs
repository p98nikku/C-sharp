using System;
using System.Collections.Generic;
using System.Text;

namespace RealTime
{
    public class VideoPlayer
    {
        private int videoplayerstatus;
        public int PlayerVideoFile(string extensionType)
        {
            if (extensionType != "mp4")
            {
                videoplayerstatus = -1;
            }
            else
            {
                videoplayerstatus = 0;
            }
            return videoplayerstatus;
        }
    }
}
