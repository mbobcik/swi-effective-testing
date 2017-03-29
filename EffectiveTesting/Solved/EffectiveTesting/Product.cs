using System;

namespace EffectiveTesting
{
    public class Product
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public DateTime Created { get; private set; }
        public string Set { get; private set; }

        public Product(DateTime created, int id, string name, string set)
        {
            Id = id;
            Created = created;
            Name = name;
            Set = set;
        }
    }
}
