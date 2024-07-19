using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_4.EmailNotificationService
{
    internal interface INotificationService
    {
        void SendNotification(string recipient, string message);

    }
}
