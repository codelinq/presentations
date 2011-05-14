using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid.Demo.LSP.Better
{
    public abstract class Product
    {
        public int Sku { get; set; }
        public decimal Cost { get; set; }

        public abstract IFormatProvider GetProductDisplayFormat();
    }
}
