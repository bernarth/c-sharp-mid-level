namespace Generics;

class Program
{
    public static T FindMaxium<T>(T[] array) where T : IComparable<T>
    {
        T max = array[0];

        foreach (var item in array)
        {
            if (item.CompareTo(max) > 0)
            {
                max = item;
            }
        }

        return max;
    }

    public static T FindMinmum<T>(T[] array) where T : IComparable<T>
    {
        T min = array[0];

        foreach (var item in array)
        {
            if (item.CompareTo(min) < 0)
            {
                min = item;
            }
        }

        return min;
    }

    public static void ContainsValue<T>(T[] array, T value)
    {   
        bool containText = false;
        foreach (var item in array)
        {
            if (item.Equals(value))
            {
                containText = true;
            }            
        }

        if (containText)
        {
            Console.WriteLine($"The array contain the value: {value}");
        }
        else
        {
            Console.WriteLine($"The array does not contain the value {value}");
        }
    }

    static void Main(string[] args)
    {
        // Test arrays
        int[] intArray = { 1, 2, 3, 4, 5 };
        double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
        string[] stringArray = { "Apple", "Banana", "Cherry", "Date" };
        string find = "Banana";

        // Testing FindMaximum
        Console.WriteLine($"The maximum number is: {FindMaxium(intArray)}");

        // Testing FindMinimum
        Console.WriteLine($"The minimum number is: {FindMinmum(doubleArray)}");

        // Testing ContainsValue
        ContainsValue<string>(stringArray, find);
    }
}
