package effectivetesting;

import static org.testng.Assert.*;

import org.testng.annotations.Test;

/**
 * Run the tests to see, you aren't able to understand what the test does.
 * TODO 1: Rename "testCreate" to something like "create_fillsAllProperties".
 * Run the tests to show the test output doesn't show why it failed and what is difference in expected and current values of the assert.
 * TDD - Explain we are now first going to fix the test before we fix the code to be able trust the test.
 * TODO 2: Implement custom Assert method to show all values, even the test fails. The method writes all values expected/current to the console so we know
 * everything from test output.
 * Show how the internal static "IdGenerator" service affects unpredictable and unreproducible data. Explain the same applies when using getting current
 * date/time in code.
 * TODO 3: Fix the production, so the test always passes.
 * Run code coverage tool to see which lines are covered and which are not.
 * Show how to toggle code coverage highlighting.
 * TODO 4: Add verification for the Id property.
 * Show how to configure "Continuous testing"/"Live testing".
 * TODO 5: Write missing tests for the other "Category" property value.
 * Modify the code to see how the tests are executed, do the same with production code.
 * Show how to find tests covering 'return "A";' statement in Factory class.
 */
public class ProductFactoryTest {
	@Test
	public void testCreate() {
		ProductFactory factory = new ProductFactory();
		Product created = factory.create("ExpectedName");
		assertEquals(created.getCategory(), "A");
		assertEquals(created.getName(), "ExpectedName");
	}
}
