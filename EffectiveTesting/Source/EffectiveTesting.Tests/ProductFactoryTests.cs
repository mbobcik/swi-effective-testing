using System;
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
        // TODO 2: Implement custom Assert method to show all values, even the test fails.The method writes all values expected/current to the console so we know everything from test output.
        // Fix the product so the test passes.
        // Show how the internal static "IdGenerator" service affects unpredictible and unreproducible data.Explain the same applies when using DateTime.Now.
        // TODO 3: Fix the production, so the test always passes.
        // Run code coverage tool to see which lines covered and which not.
        // Show how to toggle code coverage highlithing.
        // TODO 4: Add verification for the Id property.
        // Show how to configure "Continous testing"/ "Live testing".
        // TODO 5: Write missing tests for the other "Set" property value.
        // Modify the code to see how the tests are executed, do the same with production code.
        // Show how to find tests covering 'return "A";' statement in Factory class.
        [Test]
        public void TestCreate()
        {
            var factory = new ProductsFactory();
            Product created = factory.Create("ExpectedName");
            Assert.AreEqual("A", created.Set);
            Assert.AreEqual("ExpectedName", created.Name);
        }
    }
}
