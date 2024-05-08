using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTwo
{
    public class Recursion
    {
        public static int FacCalculation(int startValue)
        {
            return FacRecursion(startValue);
        }

        protected static int FacRecursion(int value)
        {
            if (value < 0)
            {
                return 0;
            }
            if (value == 1 || value == 0) 
            { 
                    return 1;
            }
            return value * FacRecursion(value - 1);
        }

        public static int CalculateFactorial(int number)
        {

            if (number < 0)
            {
                return 0;
            }
            if (number == 1 || number == 0)
            {
                return 1;
            }

            else 
            {
                int result = 1;
                for (int i = 1; i <= number; i++)
                {
                    result *= i;
                }

                return result;
            }
        }

    }
}
