﻿namespace Calc
{
    public class Calculator
    {
        public int AddNumbers(int a, int b)
        {
            return a + b;
        }

        public double AddDoubleNumbers(double a, double b)
        {
            return a + b;
        }

        public bool IsOddNumber(int a)
        {
            return (a % 2 == 0);
        }

        public bool IsEvenNumber(int a)
        {
            return (a % 2 != 0);
        }
    }
}