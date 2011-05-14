using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid.Demo.LSP.Violations
{
    public class ShoppingCart
    {
        private readonly IList<Product> _products;

        public ShoppingCart(IList<Product> products)
        {
            _products = products;
        }
        public void AddItem(Product product)
        {
            _products.Add(product);

            if (product is USProduct)
            {
                DisplayUS(product);
            }

            if (product is UKProduct)
            {
                DisplayUK(product);
            }
        }

        private void DisplayUK(Product product)
        {
            // Get the product price and format it according to the location
        }

        private void DisplayUS(Product product)
        {
            // Get the product price and format it according to the location
        }
    }
}
