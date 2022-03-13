namespace Calc
{
    public class Calculator
    {
        public List<int> RangeOfNumbers { get; set; } = new List<int>();

        public int AddNumbers(int a, int b)
        {
            return a + b;
        }

        public double AddDoubleNumbers(double a, double b)
        {
            return a + b;
        }

        public bool IsEvenNumber(int a)
        {
            return (a % 2 == 0);
        }

        public bool IsOddNumber(int a)
        {
            return (a % 2 != 0);
        }

        public List<int> GetOddRange(int min, int max)
        {
            RangeOfNumbers.Clear();
            for (int i = min; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    RangeOfNumbers.Add(i);
                }
            }
            return RangeOfNumbers;
        }

    }
}