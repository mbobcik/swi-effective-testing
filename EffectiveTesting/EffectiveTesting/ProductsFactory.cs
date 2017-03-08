using System;

namespace EffectiveTesting
{
    public class ProductsFactory
    {
        public Product Create(string name)
        {
            return new Product(DateTime.Now, name);
        }
    }
}