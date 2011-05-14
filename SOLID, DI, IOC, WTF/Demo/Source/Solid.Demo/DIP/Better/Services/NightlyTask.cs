using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Solid.Demo.DIP.Better.Domain;

namespace Solid.Demo.DIP.Better.Services
{
    public class NightlyTask : INightlyTask
    {
        private readonly ILogger _logger;

        public NightlyTask(ILogger logger)
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
