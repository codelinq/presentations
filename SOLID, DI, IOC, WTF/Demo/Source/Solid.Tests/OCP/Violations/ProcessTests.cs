using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Solid.Demo.OCP.Violations;

namespace Solid.Tests.OCP.Violations
{
    [TestFixture]
    public class when_my_process_finishes
    {
        [Test, Ignore]
        public void should_be_notified_by_growl()
        {
            var process = new SuperProcess(new GrowlNotificationService());
            process.StartProcess();

        }

    }
}
