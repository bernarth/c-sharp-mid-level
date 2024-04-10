namespace Generics;

class Program
{
    static void Main()
    {
        // Test arrays
        int[] intArray = { 1, 2, 3, 4, 5 };
        double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
        string[] stringArray = { "Apple", "Banana", "Cherry", "Date" };

        // Testing FindMaximum
        Console.WriteLine($"Maximum int value: {ArrayOperations<int>.FindMaximum(intArray)}");
        Console.WriteLine($"Maximum double value: {ArrayOperations<double>.FindMaximum(doubleArray)}");
        Console.WriteLine($"Maximum string value: {ArrayOperations<string>.FindMaximum(stringArray)}");

        // Testing FindMinimum
        Console.WriteLine($"Minimum int value: {ArrayOperations<int>.FindMinimum(intArray)}");
        Console.WriteLine($"Minimum double value: {ArrayOperations<double>.FindMinimum(doubleArray)}");
        Console.WriteLine($"Minimum string value: {ArrayOperations<string>.FindMinimum(stringArray)}");

        // Testing ContainsValue
        Console.WriteLine($"Array contains 4? : {ArrayOperations<int>.ContainsValue(intArray, 4)}");
        Console.WriteLine($"Array contains 3.3? : {ArrayOperations<double>.ContainsValue(doubleArray, 3.3)}");
        Console.WriteLine($"Array contains Banana? : {ArrayOperations<string>.ContainsValue(stringArray, "Banana")}");
        Console.WriteLine($"Array contains 6? : {ArrayOperations<int>.ContainsValue(intArray, 6)}");
        Console.WriteLine($"Array contains 7.3? : {ArrayOperations<double>.ContainsValue(doubleArray, 7.3)}");
        Console.WriteLine($"Array contains Hourse? : {ArrayOperations<string>.ContainsValue(stringArray, "Hourse")}");
    }
}
