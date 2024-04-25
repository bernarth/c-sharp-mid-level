namespace DayOne;

using System.Collections.Generic;

public class FilteringSolution
{
    public static List<int> GetIntegersFromList(List<object> listOfItems)
    {        
        List<int> result = new List<int>();

        foreach (object item in listOfItems)
        {
            if (item is int)
            {
                int number = (int)item;
                if (number >= 0)
                {
                    result.Add(number);
                }                
            }
        }        

        return result;
    }

    public static void PrintList(List<int> list)
    {
        string result = string.Join(", ", list);
        Console.WriteLine(result);
    }
}