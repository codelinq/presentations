using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid.Demo.LSP.Better
{
    public class UKProduct : Product
    {
        public override IFormatProvider GetProductDisplayFormat()
        {
            return null;
        }
    }
}
