using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Solid.Demo.DIP.Better.Domain;

namespace Solid.Demo.DIP.Better.Infrastructure
{
    public class DbLogger : ILogger
    {
        public void Log(Exception ex)
        {
            //log to database
        }
    }
}
