using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid.Demo.OCP.Better
{
    public interface INotificationService
    {
        void Notify(string message);
    }
}
