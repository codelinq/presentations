using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid.Demo.OCP.Better
{
    public class BulkNotificationService : INotificationService
    {
        private readonly IEnumerable<INotificationService> _services;

        public BulkNotificationService(params INotificationService[] services)
        {
            _services = services;
        }

        public void Notify(string message)
        {
            foreach (var service in _services)
            {
                service.Notify(message);
            }
        }
    }
}
