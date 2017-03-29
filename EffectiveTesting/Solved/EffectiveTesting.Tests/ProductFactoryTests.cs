using System;
using NUnit.Framework;

namespace EffectiveTesting.Tests
{
    [TestFixture]
    public class ProductFactoryTests
    {
        // Fix the test to:
        // have self descriptive name.
        // catch errors related to Name change (Write custom assert method).
        // TODO: avoid DateTime.UtcNow, to be able reproduce the test with the same data.
        // TODO: be able understand why it fails.

        // Fix the production code to:    
        // TODO: be able write unit tests (Unit == Class).
        [Test]
        public void Create_FillsAllProperties()
        {
            var factory = new ProductsFactory();
            const string expectedName = "ExpectedName";
            Product created = factory.Create(expectedName);
            AssertProductIsSetTo(created, expectedName, 1, DateTime.UtcNow.AddSeconds(-1));
        }

        private void AssertProductIsSetTo(Product current, string expectedName, int expectedId, DateTime expectedDateCreated)
        {
            WriteExpectationsToConsole(current, expectedName, expectedId, expectedDateCreated);

            bool allEquals = current.Name == expectedName &&
                current.Id == expectedId &&
                expectedDateCreated < current.Created;

            Assert.IsTrue(allEquals, "Product doesnt match expected initialization.");
        }

        private static void WriteExpectationsToConsole(Product current, string expectedName, int expectedId, DateTime expectedDateCreated)
        {
            Console.WriteLine($"Name: Current='{current.Name}',Expected='{expectedName}'");
            Console.WriteLine($"Set: Current='{current.Set}',Expected='{expectedId}'");
            Console.WriteLine($"Id: Current='{current.Created}',Expected='{expectedDateCreated}'");
        }
    }
}
