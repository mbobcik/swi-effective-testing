using System;

namespace EffectiveTesting
{
    public class Product
    {
        public string Name { get; private set; }

        public DateTime Created { get; private set; }

        public Product(DateTime created, string name)
        {
            Created = created;
            Name = name;
        }
    }
}
