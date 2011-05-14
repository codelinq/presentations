using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid.Demo.ISP.Violations
{
    public class BusinessObject : IBusinessObject
    {
        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}
