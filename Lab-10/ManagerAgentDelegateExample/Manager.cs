using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerAgentDelegateExample
{
    public class Manager
    {
        public delegate bool sendMessageDelegate(Message m);
        private Agent.tasksenddelegate td;
        Agent a;
        public Manager()
        {
            a = new Agent();
        }
        public void RequestDelivery(Message m, sendMessageDelegate t) {
            td = new Agent.tasksenddelegate(t);
            a.doTask(td, m);
            a.notificationChanged += new Agent.NotificationHandler((o, e) =>
            {
                Console.WriteLine(e.status);
            });
        }
    }
}
