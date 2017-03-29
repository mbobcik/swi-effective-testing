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
        // avoid DateTime.UtcNow, to be able reproduce the test with the same data.
        // TODO: be able understand why it fails.

        // Fix the production code to:    
        // TODO: be able write unit tests (Unit == Class).
        [Test]
        public void Create_FillsAllProperties()
        {
            //IdGenerator.Current = 99;
            var factory = new ProductsFactory();
            const string expectedName = "ExpectedName";
            Product created = factory.Create(expectedName);
            AssertProductIsSetTo(created, expectedName, "A", 100);
        }

        private void AssertProductIsSetTo(Product current, string expectedName, string expectedSet, int expectedId)
        {
            WriteExpectationsToConsole(current, expectedName, expectedSet, expectedId);

            bool allEquals = current.Name == expectedName &&
                current.Set == expectedSet &&
                expectedId == current.Id;

            Assert.IsTrue(allEquals, "Product doesnt match expected initialization.");
        }

        private static void WriteExpectationsToConsole(Product current, string expectedName, string expectedSet, int expectedId)
        {
            Console.WriteLine($"Name: Current='{current.Name}',Expected='{expectedName}'");
            Console.WriteLine($"Set: Current='{current.Set}',Expected='{expectedSet}'");
            Console.WriteLine($"Id: Current='{current.Id}',Expected='{expectedId}'");
        }
    }
}
