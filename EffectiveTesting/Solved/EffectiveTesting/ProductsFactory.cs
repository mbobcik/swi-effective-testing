namespace EffectiveTesting
{
    public class ProductsFactory
    {
        private readonly IIdGenerator idGenerator;

        public ProductsFactory(IIdGenerator idGenerator)
        {
            this.idGenerator = idGenerator;
        }

        public Product Create(string name)
        {
            int newId = this.idGenerator.NextId();
            string set = ResolveSet(newId);
            return new Product(newId, name, set);
        }

        private static string ResolveSet(int newId)
        {
            bool isSet = newId % 10 == 0;

            if (isSet)
                return "A";

            return "B";
        }
    }
}