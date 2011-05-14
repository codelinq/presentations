using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid.Demo.OCP.Better
{
    public class EmailNotificationService : INotificationService
    {
        public void Notify(string message)
        {
            SendMail(message);
        }

        private void SendMail(string message)
        {
        }
    }
}
