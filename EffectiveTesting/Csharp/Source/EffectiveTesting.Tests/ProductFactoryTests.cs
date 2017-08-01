using System;
using Moq;
using NUnit.Framework;

namespace EffectiveTesting.Tests
{
    [TestFixture]
    public class ProductFactoryTests
    {
        // Run the tests to see, you arent able to understand what the test does.
        // TODO 1:Rename "TestCreate" to something like "Create_FillsAllProperties".
        // Run the tests to show the test output doesnt show why it failed and what is difference in expected and current values of the assert.
        // TDD - Explain we are now first going to fix the test before we fix the code to be able trust the test.
        // TODO 2: Implement custom Assert method to show all values, even the test fails.The method writes all values\
        // todo expected/current to the console so we know everything from test output.
        // Show how the internal static "IdGenerator" service affects unpredictible and unreproducible data.
        // Explain the same applies when using DateTime.Now.
        // TODO 3: Fix the production, so the test always passes.
        // Run code coverage tool to see which lines covered and which not.
        // Show how to toggle code coverage highlithing.
        // TODO 4: Add verification for the Id property.
        // Show how to configure "Continous testing"/ "Live testing".
        // TODO 5: Write missing tests for the other "Set" property value.
        // Modify the code to see how the tests are executed, do the same with production code.
        // Show how to find tests covering 'return "A";' statement in Factory class.
        [Test]
        public void Create_NameSetA_Successfull()
        {
            var mockGenerator = new Mock<IIdGenerator>();
            mockGenerator.Setup(g => g.NextId()).Returns(2);
            var factory = new ProductsFactory(mockGenerator.Object);
            Product created = factory.Create("ExpectedName");

            //ReSharper -> Ctrl+R,M = refactor
            //udela z dvou radku asertuu funkci
            AssertCreatedProduct(created,"ExpectedName", "A");
        }

        [Test]
        public void Create_NameSetB_Successfull()
        {
            var mockGenerator = new Mock<IIdGenerator>();
            mockGenerator.Setup(g => g.NextId()).Returns(1);
            var factory = new ProductsFactory(mockGenerator.Object);
            Product created = factory.Create("ExpectedName");

            //ReSharper -> Ctrl+R,M = refactor
            //udela z dvou radku asertuu funkci
            AssertCreatedProduct(created, "ExpectedName", "B");
        }


        private static void AssertCreatedProduct(Product created, string expectedName, string expextedSet)
        {
            Assert.AreEqual(expextedSet, created.Set);
            Assert.AreEqual(expectedName, created.Name);

            //string message = Message(created, expectedName, expextedSet);

            //bool result =
        }

        private static string Message(Product current, string expectedName, string expectedSet)
        {
            return "Product not match expectetion\nName: Current...";
        }
    }
}
