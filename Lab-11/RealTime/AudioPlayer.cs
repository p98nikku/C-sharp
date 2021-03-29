using System;
using System.Collections.Generic;
using System.Text;

namespace RealTime
{
    public class AudioPlayer
    {
        private int audioplayerstatus;
        public int PlayerAudioFile(string extensionType)
        {
            if(extensionType!="mp3")
            {
                audioplayerstatus = -1;
            }
            else
            {
                audioplayerstatus = 0;
            }
            return audioplayerstatus;
        }

        
    }
}
