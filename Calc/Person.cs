namespace Calc
{
    public class Person
    {

        public string Message { get; set; }

        public int Discount { get; set; } = 15;
        public string GreetAndCombineNames(string firstName, string lastName)
        {
            Message = $"Hello {firstName} {lastName}";
            Discount = 20;
            return Message;
        }
    }
}
