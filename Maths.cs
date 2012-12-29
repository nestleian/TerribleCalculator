using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorTest
{
    class Maths
    {

        public decimal Subtraction(decimal first, decimal second)
        {
            decimal sum = first - second;
            return sum;
        }

        public decimal Addition(decimal first, decimal second)
        {
            decimal sum = first + second;
            return sum;
        }

        public decimal Division(decimal first, decimal second)
        {
            decimal sum = (decimal)first / (decimal)second;
            return sum;
        }

        public decimal Times(decimal first, decimal second)
        {
            decimal sum = first * second;
            return sum;
        }
    }
}
