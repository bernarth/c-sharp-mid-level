namespace DayOne;

using System.Collections.Generic;

public class FilteringSolution
{
    public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
    {
        object test = 12;
        Console.WriteLine(test.GetType() == typeof(int));

        return new List<int>();
    }
}