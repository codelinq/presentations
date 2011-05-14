using System;

namespace Solid.Demo.ISP.Better
{
    public class BusinessObject: IBusinessObject, IPersistable, IValidatable
    {
        public void Validate()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }
    }
}
