using System.Collections.Generic;

namespace Solid.Demo.ISP.Better
{
    public class Validator
    {
        public void Validate(IEnumerable<IValidatable> validatables)
        {
            if (validatables != null)
            {
                foreach (var validatable in validatables)
                {
                    validatable.Validate();
                }
            }
        }
    }
}
