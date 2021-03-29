using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerAgentDelegateExample
{
    public class NotificationEventArgs:EventArgs
    {
        public bool status;
        public NotificationEventArgs(bool s)
        {
            status = s;
        }
    }
}
