﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid.Demo.DIP.Better.Domain
{
    public interface ILogger
    {
        void Log(Exception ex);
    }
}
