using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid.Demo.OCP.Better
{
    public class GrowlNotificationService : INotificationService
    {
        public void Notify(string message)
        {
            SendGrowl(message);
        }

        private void SendGrowl(string message)
        {

        }

    }
}
