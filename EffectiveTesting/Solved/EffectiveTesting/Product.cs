using System;

namespace EffectiveTesting
{
    public class Product
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public string Set { get; private set; }

        public Product(int id, string name, string set)
        {
            Id = id;
            Name = name;
            Set = set;
        }
    }
}
