using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid.Demo.ISP.Violations
{
    public interface IBusinessObject
    {
        void Save();
        void Delete();
        bool Validate();
    }
}
