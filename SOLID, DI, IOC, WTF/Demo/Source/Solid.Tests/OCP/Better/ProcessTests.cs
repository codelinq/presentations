using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;
using NUnit.Framework;

using Shouldly;

using Solid.Demo.OCP.Better;

namespace Solid.Tests.OCP.Better
{
    [TestFixture]
    public class when_my_process_finishes
    {
        [Test]
        public void should_notify_mock_growl()
        {
            string growlMessage = string.Empty;
            bool growled = false;

            var mockGrowl = new Mock<INotificationService>();
            mockGrowl.Setup(g => g.Notify(It.IsAny<string>())).Callback((string msg) =>
                                                                        {
                                                                            growlMessage = msg;
                                                                            growled = true;
                                                                        });
            var growlService = mockGrowl.Object;
            var process = new SuperProcess(growlService);
            process.StartProcess();

            growled.ShouldBe(true);
            growlMessage.ShouldNotBe(string.Empty);
        }
    }
}
