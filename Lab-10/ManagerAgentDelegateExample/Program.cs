using System;

namespace ManagerAgentDelegateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m1 = new Manager();
            Message m1Message = new Message
            {
                Address = "abc",
                Content = "this a message"
            };
            Manager.sendMessageDelegate md = SendTypes.SendByCar;
            m1.RequestDelivery(m1Message, md);
            Agent a = new Agent();
            a.notificationChanged += new Agent.NotificationHandler(ShowNotification);
        }
        public static void ShowNotification(object theAgent, NotificationEventArgs e)
        {
            Console.WriteLine(e.status);
        }
    }
}
