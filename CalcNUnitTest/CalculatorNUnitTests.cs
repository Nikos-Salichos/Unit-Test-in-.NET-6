using Calc;
using NUnit.Framework;

namespace CalcNUnitTest
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        readonly Calculator calculator = new Calculator();

        [Test]
        public void AddNumbers_InputTwoIntegers_ReturnsAddedIntegers()
        {
            //Act phase
            int result = calculator.AddNumbers(10, 20);

            //Assert phase
            Assert.AreEqual(30, result);
        }

        [Test]
        [TestCase(11.10, 35.21)]
        public void AddDoubleNumbers_InputTwoDouble_ReturnsAddedDoubles(double a, double b)
        {
            //Act phase
            double result = calculator.AddDoubleNumbers(a, b);

            //Assert phase
            Assert.AreEqual(46.31, result);
        }

        [Test]
        [TestCase(10)]
        public void IsEvenNumber_InputAnInteger_ReturnsTrue(int a)
        {
            bool isOddNumber = calculator.IsEvenNumber(a);
            Assert.That(isOddNumber, Is.EqualTo(true));
        }

        [Test]
        [TestCase(11)]
        public void IsOddNumber_InputAnInteger_ReturnsTrue(int a)
        {
            bool isEvenNumber = calculator.IsOddNumber(a);
            Assert.That(isEvenNumber, Is.EqualTo(true));
        }

        [Test]
        [TestCase(9, ExpectedResult = true)]
        [TestCase(10, ExpectedResult = false)]
        public bool IsOddNumberTestCases(int a)
        {
            return calculator.IsOddNumber(a);
        }

        [Test]
        public void OddRange_InputMinMaxRange_Returns()
        {
            List<int> expectedOddRange = new List<int> { 5, 7, 9 };
            List<int> result = calculator.GetOddRange(5, 10);

            Assert.That(result, Is.EquivalentTo(expectedOddRange));
        }

    }
}