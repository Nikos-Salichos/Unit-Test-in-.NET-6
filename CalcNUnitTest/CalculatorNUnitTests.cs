using Calc;
using NUnit.Framework;

namespace CalcNUnitTest
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        Calculator calculator = new Calculator();

        [Test]
        public void AddNumbers_InputTwoIntegers_GetCorrectResult()
        {
            //Act phase
            int result = calculator.AddNumbers(10, 20);

            //Assert phase
            Assert.AreEqual(30, result);
        }

        [Test]
        [TestCase(10)]
        public void IsOddNumber(int a)
        {
            bool isOddNumber = calculator.IsOddNumber(a);
            Assert.That(isOddNumber, Is.EqualTo(true));
        }

        [Test]
        [TestCase(11)]
        public void IsEvenNumber(int a)
        {
            bool isEvenNumber = calculator.IsEvenNumber(a);
            Assert.That(isEvenNumber, Is.EqualTo(true));
        }

        [Test]
        [TestCase(10, ExpectedResult = true)]
        [TestCase(11, ExpectedResult = false)]
        public bool IsOddNumber_CombineTestCases(int a)
        {
            return calculator.IsOddNumber(a);
        }

    }
}