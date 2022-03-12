using NUnit.Framework;

namespace Calc
{
    public class PersonNUnitTests
    {
        readonly Person person = new Person();

        [Test]
        public void CombineName_InputFirstAndLastName_ReturnFullName()
        {
            string fullName = person.GreetAndCombineNames("Nikos", "Sal");

            Assert.That(fullName, Is.EqualTo("Hello Nikos Sal"));
            Assert.That(fullName, Does.Contain("Hello").IgnoreCase);
            Assert.That(fullName, Does.StartWith("H"));
            Assert.That(fullName, Does.EndWith("Sal"));
            Assert.That(fullName, Does.Match("Hello [A-Z]{1}[a-z]+"));
        }


    }
}
