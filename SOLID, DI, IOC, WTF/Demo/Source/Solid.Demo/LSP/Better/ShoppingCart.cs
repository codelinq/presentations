using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solid.Demo.LSP.Better
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

            DisplayProduct(product);
        }

        private void DisplayProduct(Product product)
        {
            product.Cost.ToString(product.GetProductDisplayFormat());
        }
    }
}
