namespace DayTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = TreeNode.Leaf().WithLeaves();
            Console.WriteLine(TreeNode.IsPerfect(root));

            var number = 4;
            var secondNumber = 6;

            Console.WriteLine($"Factorial of {number} is {Factorial.FacRecursion(number)}");

            Console.WriteLine($"Factorial of {secondNumber} is {Factorial.GetFactorialUsingCycle(secondNumber)}");
        }
    }
}
