using Calc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcMSTest
{
    [TestClass]
    public class CalculatorMSTests
    {
        [TestMethod]
        public void AddNumbers_InputTwoIntegers_GetCorrectResult()
        {
            //Arrange phase
            Calculator calculator = new Calculator();

            //Act phase
            int result = calculator.AddNumbers(10, 20);

            //Assert phase
            Assert.AreEqual(30, result);
        }
    }
}
