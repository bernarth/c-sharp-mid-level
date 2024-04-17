namespace Recursion;

internal class Program
{
    static void Main(string[] args)
    {
        int num1 = 120;
        int num2 = 156;

        Console.WriteLine($"The Greatest Common Divisor (GCD) of ({num1} and {num2}) are: {GetGreatestCommonDivisor(num1, num2)}");
    }

    public static int GetGreatestCommonDivisor(int num1, int num2)
    {  
        if (num2 > num1)
        {
            int aux = num1;
            num1 = num2;
            num2 = aux;
        }
        
        if (num2 == 0)
        {
            return num1;
        }
        else 
        {
            return GetGreatestCommonDivisor(num2, num1%num2);
        }        
    }
}
