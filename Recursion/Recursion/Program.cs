namespace Recursion
{
    public class Program
    {

        /// <summary>
        /// Gets the greatest common divisor for two numbers.
        /// </summary>
        /// <param name="firstNumber">The first number.</param>
        /// <param name="secondNumber">The second number.</param>
        /// <returns></returns>
        public static int GetGreatestCommonDivisor(int firstNumber, int secondNumber)
        {
            if (secondNumber == 0)
            {
                return firstNumber;
            }
            else
            {
                return GetGreatestCommonDivisor(secondNumber, firstNumber % secondNumber);
            }
        }

        static void Main()
        {
            Console.WriteLine($"The greatest common divisor of 156 and 120 is: {GetGreatestCommonDivisor(156, 120)}");
            Console.WriteLine($"The greatest common divisor of 100 and 60 is: {GetGreatestCommonDivisor(100, 60)}");
        }
    }
}
