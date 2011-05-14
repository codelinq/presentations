using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SolidApp.Domain.Services;

namespace SolidApp.Infrastructure
{
    public class EmailService : IEmailService
    {
        public void Send(string from, string to, string message)
        {
            //send it
        }
    }
}
