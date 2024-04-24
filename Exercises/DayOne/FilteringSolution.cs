namespace DayOne;

using System.Collections.Generic;

public class FilteringSolution
{
    public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
    {

        var result = new List<int>();

        foreach (object item in listOfItems)
        {
            if (item.GetType() == typeof(int))
            {
                result.Add((int)item);
            }
        }

        return result;
    }

    public static void PrintList(IEnumerable<int> list)
    {
        Console.WriteLine(string.Join(",", list));
    }
}