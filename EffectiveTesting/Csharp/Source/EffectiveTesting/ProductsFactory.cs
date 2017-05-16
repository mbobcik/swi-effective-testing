namespace EffectiveTesting
{
    public class ProductsFactory
    {
        public Product Create(string name)
        {
            int newId = IdGenerator.NextId();
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