using System;
using System.Collections.Generic;
using System.Text;

namespace RealTime
{
    public class MediaStorage
    {
        public delegate int PlayerMedia(string a);
        public void ReportResult(PlayerMedia p,string type)
        {
            var status = p(type);
            if(status==0)
            {
                Console.WriteLine("Media exist");
            }
            else
            {
                Console.WriteLine("Media does not exist");
            }
        }
    }
}
