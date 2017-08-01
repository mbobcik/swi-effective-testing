namespace EffectiveTesting
{
    public class ProductsFactory
    {

        private IIdGenerator idGenerator;

        public ProductsFactory(IIdGenerator idGenerator)
        {
            this.idGenerator = idGenerator;
        }

        public Product Create(string name)
        {
            int newId = idGenerator.NextId();
            string set = ResolveSet(newId);
            return new Product(newId, name, set);
        }

        private static string ResolveSet(int newId)
        {
            bool isSet = newId % 2 == 0;

            if (isSet)
                return "A";

            return "B";
        }
    }
}