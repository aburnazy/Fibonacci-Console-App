using NUnit.Framework;
using Library;

namespace Tests
{
    class FibonacciGeneratorTests
    {
        [Test]
        public void GenerateFibonacciNumbersTest()
        {
            int[] expectedValues = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            int i = 0;

            FibonacciGenerator fibonacciGenerator = new FibonacciGenerator();
            foreach (var fibNumber in fibonacciGenerator.Generate(expectedValues.Length))
            {
                Assert.AreEqual(fibNumber, expectedValues[i++]);
            }           
        }
    }
}