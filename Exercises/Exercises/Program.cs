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
    }
}
