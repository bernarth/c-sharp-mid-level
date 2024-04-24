namespace Exercises;

using DayOne;

public class Program
{
    static void Main()
    {
        var result = Template.NumericFormatter("xxxx yyyy zzzz");
        Console.WriteLine(result);

        var tree = new TreeNode(17,
            new TreeNode(3,
                new TreeNode(2), null),
            new TreeNode(-10,
                new TreeNode(16), new TreeNode(1,
                    new TreeNode(13))));
        var resultTree = TreeSolution.MaxSum(tree);
        Console.WriteLine(resultTree);

        var list = new List<object>() { 1, 2, "a", "b" };
        var listInteger = FilteringSolution.GetIntegersFromList(list);

        Console.Write("Get Integers From List: ");
        FilteringSolution.PrintList(listInteger);

        var listIntegers = new int[] { 1, 1, 2, 3, 1, 2, 3, 4, 4, 3, 5, 6, 7, 2, 8 };
        var listValuesToRemove = new int[] { 1, 3, 4, 2 };

        var listAfterRemovingMarkedElements = RemoveMarkedElementsSolution.Remove(listIntegers, listValuesToRemove);
        Console.Write("Remove All The Marked Elements of a List: ");
        RemoveMarkedElementsSolution.PrintList(listAfterRemovingMarkedElements);
    }
}
