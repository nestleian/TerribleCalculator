using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorTest
{
    class Maths
    {

        public int Subtraction(int first, int second)
        {
            int sum = first - second;
            return sum;
        }

        public int Addition(int first, int second)
        {
            int sum = first + second;
            return sum;
        }

        public int Division(int first, int second)
        {
            int sum = first / second;
            return sum;
        }

        public int Times(int first, int second)
        {
            int sum = first * second;
            return sum;
        }
    }
}
