using NUnit.Framework;

namespace NUnitTestCalculator
{
    public class Tests
    {
        [TestCase(1, 1, 2)]
        [TestCase(7, 16, 23)]
        [TestCase(5, -5, 0)]
        public void PlusTest(int x, int y, int z)
        {
            int temp = Calculator.Plus(x, y);
            Assert.AreEqual(z, temp);
        }

        [TestCase(10, 5, 5)]
        [TestCase(10, 0, 10)]
        [TestCase(10, 20, -10)]
        [TestCase(10, -10, 20)]
        public void MinusTest(int x, int y, int z)
        {
            int temp = Calculator.Minus(x, y);
            Assert.AreEqual(z, temp);
        }

        [TestCase(10, 5, 50)]
        [TestCase(10, 0, 0)]
        [TestCase(10, -20, -200)]
        public void MultiplicationTest(int x, int y, int z)
        {
            int temp = Calculator.Multiplication(x, y);
            Assert.AreEqual(z, temp);
        }

        [TestCase(10, 5, 2)]
        [TestCase(10, 0, 0)]
        [TestCase(0, 10, 0)]
        [TestCase(10, -5, -2)]
        public void DivisionTest(int x, int y, int z)
        {
            int temp = Calculator.Division(x, y);
            Assert.AreEqual(z, temp);
        }
    }
}