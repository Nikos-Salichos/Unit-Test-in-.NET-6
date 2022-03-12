using Calc;
using NUnit.Framework;

namespace CalcNUnitTest
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        readonly Calculator calculator = new Calculator();

        [Test]
        public void AddNumbers_InputTwoIntegers_GetAddedIntegers()
        {
            //Act phase
            int result = calculator.AddNumbers(10, 20);

            //Assert phase
            Assert.AreEqual(30, result);
        }

        [Test]
        [TestCase(11.10, 35.21)]
        public void AddDoubleNumbers_InputTwoDouble_GetAddedDoubles(double a, double b)
        {
            //Act phase
            double result = calculator.AddDoubleNumbers(a, b);

            //Assert phase
            Assert.AreEqual(46.31, result);
        }

        [Test]
        [TestCase(10)]
        public void IsOddNumber_InputAnInteger_GetTrue(int a)
        {
            bool isOddNumber = calculator.IsOddNumber(a);
            Assert.That(isOddNumber, Is.EqualTo(true));
        }

        [Test]
        [TestCase(11)]
        public void IsEvenNumber_InputAnInteger_GetTrue(int a)
        {
            bool isEvenNumber = calculator.IsEvenNumber(a);
            Assert.That(isEvenNumber, Is.EqualTo(true));
        }

        [Test]
        [TestCase(10, ExpectedResult = true)]
        [TestCase(11, ExpectedResult = false)]
        public bool IsOddNumberTestCases(int a)
        {
            return calculator.IsOddNumber(a);
        }

    }
}