using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid.Demo.OCP.Violations
{
    public class SuperProcess
    {
        private GrowlNotificationService _notifier;

        public SuperProcess(GrowlNotificationService notifier)
        {
            _notifier = notifier;
        }

        public void StartProcess()
        {
            //do long running process;

            _notifier.Growl();
        }
    }
}
