namespace Exercises;

using DayOne;

public class Program
{
    static void Main()
    {
        //var result = Template.NumericFormatter("xxxx yyyy zzzz");
        //Console.WriteLine(result);

        //var tree = new TreeNode(17,
        //    new TreeNode(3, 
        //        new TreeNode(2), null), 
        //    new TreeNode(-10, 
        //        new TreeNode(16), new TreeNode(1, 
        //            new TreeNode(13))));
        //var result = TreeSolution.MaxSum(tree);
        //Console.WriteLine(result);



        //List<object> list = new List<object>() { 1, 2, "a", -5, 1, "n" };
        //List<int> newList = FilteringSolution.GetIntegersFromList(list);
        //FilteringSolution.PrintList(newList);

        Console.WriteLine("kata1: Remove All The Marked Elements of a List\n");
        int[] nums = [1, 2, -5, 1, 3, 4, 3, 1, 2, 4];
        int[] remove = [1, 3];
        int[] result = RemoveElements.Remove(nums, remove);

        Console.Write($"{string.Join(",", result)}");

        Console.WriteLine("\n\nkata2: Find Count of Most Frequent Item in an Array\n");
        int[] collection = [3, -1, -1, -1, 2, 3, -1, 3, -1, 2, 4, 9, 3];
        Console.WriteLine(CountMostFrequentItem.MostFrequentItem(collection));
    }
}
