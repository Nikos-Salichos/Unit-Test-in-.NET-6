namespace Calc
{
    public class Person
    {

        public string Message { get; set; }

        public string GreetAndCombineNames(string firstName, string lastName)
        {
            Message = $"Hello {firstName} {lastName}";
            return Message;
        }
    }
}
