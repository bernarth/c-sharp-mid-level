using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTwo
{
    public class Factorial
    {
        public static int FacRecursion(int value)
        {
            if (value < 0)
            {
                return 0;
            }

            if (value == 1 | value == 0)
            {
                return 1;
            }

            return value * FacRecursion(value - 1);
        }

        public static int GetFactorialUsingCycle(int number)
        {
            var result = 1;

            for (var i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
