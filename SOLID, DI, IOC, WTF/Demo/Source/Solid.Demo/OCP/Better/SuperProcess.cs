using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid.Demo.OCP.Better
{
    public class SuperProcess
    {
        private INotificationService _notifier;

        public SuperProcess(INotificationService notifier)
        {
            _notifier = notifier;
        }

        public void StartProcess()
        {
            //do long running process;

            _notifier.Notify("SuperProcess is all done!");
        }
    }
}
