using System;
using NUnit.Framework;

namespace EffectiveTesting.Tests
{
    [TestFixture]
    public class ProductFactoryTests
    {
        [Test]
        public void TestCreate()
        {
            var factory = new ProductsFactory();
            Product created = factory.Create("ExpectedName");
            Assert.AreEqual("ExpectedName", created.Name);
            Assert.IsTrue(DateTime.Now.AddSeconds(-1) < created.Created);
        }
    }
}
