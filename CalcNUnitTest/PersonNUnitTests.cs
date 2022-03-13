using NUnit.Framework;

namespace Calc
{
    [TestFixture]
    public class PersonNUnitTests
    {
        private Person person;
        [SetUp]
        public void Setup()
        {
            person = new Person();
        }

        [Test]
        public void CombineName_InputFirstAndLastName_ReturnFullName()
        {
            person.GreetAndCombineNames("Nikos", "Sal");

            Assert.That(person.Message, Is.EqualTo("Hello Nikos Sal"));
            Assert.That(person.Message, Does.Contain("Hello").IgnoreCase);
            Assert.That(person.Message, Does.StartWith("H"));
            Assert.That(person.Message, Does.EndWith("Sal"));
            Assert.That(person.Message, Does.Match("Hello [A-Z]{1}[a-z]+"));
        }

        [Test]
        public void GreetMessage_ReturnNull()
        {
            // person.GreetAndCombineNames("Nikos", "Sal");
            Assert.IsNull(person.Message);
        }


    }
}
