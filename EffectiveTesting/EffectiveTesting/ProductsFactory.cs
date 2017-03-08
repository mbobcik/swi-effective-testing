using System;

namespace EffectiveTesting
{
    public class ProductsFactory
    {
        public Product Create(string name)
        {
            int newId = IdGenerator.NextId();
            return new Product(DateTime.UtcNow, newId, name);
        }
    }
}