using System;
using System.Collections.Generic;
using System.Text;

namespace _01042022
{
    class Library
    {
        public Product[] Products = new Product[0];
        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;
        }

        public Product[] GetProductByName(string exm)
        {
            Product[] filteredProducts = new Product[0];
            int j = 0;
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].Name.Contains(exm))
                {
                    Array.Resize(ref filteredProducts, filteredProducts.Length + 1);
                    filteredProducts[j] = Products[i];
                    j++;
                }
            }
            return filteredProducts;
        }
    }
}
