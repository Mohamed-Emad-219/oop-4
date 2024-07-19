using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_4.EmailNotificationService
{
    internal class PushNotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Sending Notification to  {recipient} : {message}");
        }
    }
}
