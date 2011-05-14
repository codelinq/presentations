using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Solid.Demo.DIP.Violations.Infrastructure;

namespace Solid.Demo.DIP.Violations
{
    public class NightlyTask
    {
        private readonly ElmahLogger _logger;

        public NightlyTask(ElmahLogger logger)
        {
            _logger = logger;
        }

        public void ProcessWork()
        {
            try 
            { 
                // to do work
            }
            catch (Exception ex)
            {
                _logger.Log(ex);
                throw;
            }
        }
    }
}
