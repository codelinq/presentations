using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidApp.Domain.Services
{
    public interface IEmailService
    {
        void Send(string from, string to, string message);
    }
}
