using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid.Demo.ISP.Violations
{
    public class DbContext
    {
        public void Save(IEnumerable<IBusinessObject> businessObjects)
        {
            if (businessObjects != null)
            {
                foreach (var businessObject in businessObjects)
                {
                    businessObject.Save();
                }
            }
        }

        public void Delete(IEnumerable<IBusinessObject> businessObjects)
        {
            if (businessObjects != null)
            {
                foreach (var businessObject in businessObjects)
                {
                    businessObject.Delete();
                }
            }
        }
    }
}
