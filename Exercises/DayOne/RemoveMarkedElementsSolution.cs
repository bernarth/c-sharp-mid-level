namespace DayOne;

public class RemoveMarkedElementsSolution
{
    public static int[] Remove(int[] integerList, int[] valuesList)
    {

        var numbersList = integerList.ToList();

        foreach (int value in valuesList)
        {
            foreach (int number in integerList)
            {
                if (number == value)
                {
                    numbersList.Remove(number);
                }
            }    
        }

        return numbersList.ToArray();
    }

    public static void PrintList(int[] integerList)
    {
        Console.WriteLine(string.Join(",", integerList));
    }
}
