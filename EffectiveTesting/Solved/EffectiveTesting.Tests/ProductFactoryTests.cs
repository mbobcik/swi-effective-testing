using System;
using NUnit.Framework;

namespace EffectiveTesting.Tests
{
    [TestFixture]
    public class ProductFactoryTests
    {
        // Fix the test to:
        // have self descriptive name.
        // TODO: catch errors related to Name change (Write custom assert method).
        // TODO: avoid DateTime.UtcNow, to be able reproduce the test with the same data.
        // TODO: be able understand why it fails.

        // Fix the production code to:    
        // TODO: be able write unit tests (Unit == Class).
        [Test]
        public void Create_FillsAllProperties()
        {
            var factory = new ProductsFactory();
            Product created = factory.Create("ExpectedName");
            Assert.AreEqual(100, created.Id);
            Assert.AreEqual("B", created.Set);
            Assert.AreEqual("ExpectedName", created.Name);
            Assert.IsTrue(DateTime.UtcNow.AddSeconds(-1) < created.Created);
        }
    }
}
