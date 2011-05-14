using System.Collections.Generic;

namespace Solid.Demo.ISP.Better
{
    public class DbContext
    {
        public void Save(IEnumerable<IPersistable> persistables)
        {
            if (persistables != null)
            {
                foreach (var persistable in persistables)
                {
                    persistable.Save();
                }
            }
        }

        public void Delete(IEnumerable<IPersistable> persistables)
        {
            if (persistables != null)
            {
                foreach (var persistable in persistables)
                {
                    persistable.Delete();
                }
            }
        }
    }
}
