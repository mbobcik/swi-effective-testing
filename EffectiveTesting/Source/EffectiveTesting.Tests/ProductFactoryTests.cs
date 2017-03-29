using System;
using NUnit.Framework;

namespace EffectiveTesting.Tests
{
    [TestFixture]
    public class ProductFactoryTests
    {
        // Fix the test to:
        // TODO: have self descriptive name.
        // TODO: be able understand why it fails.
        // TODO: catch errors related to Name change (Write custom assert method).
        // TODO: avoid IdGenerator, to be able reproduce the test with the same data.
        // TODO: add missing tests.

        // Fix the production code to:    
        // TODO: be able write unit tests (Unit == Class).
        [Test]
        public void TestCreate()
        {
            var factory = new ProductsFactory();
            Product created = factory.Create("ExpectedName");
            Assert.AreEqual(100, created.Id);
            Assert.AreEqual("A", created.Set);
            Assert.AreEqual("ExpectedName", created.Name);
        }
    }
}
