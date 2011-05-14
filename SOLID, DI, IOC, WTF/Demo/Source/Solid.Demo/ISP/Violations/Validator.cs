using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid.Demo.ISP.Violations
{
    public class Validator
    {
        public void Validate(IEnumerable<IBusinessObject> businessObjects)
        {
            if (businessObjects != null)
            {
                foreach (var businessObject in businessObjects)
                {
                    businessObject.Validate();
                }
            }
        }
    }
}
