namespace DayTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = TreeNode.Leaf().WithLeaves();
            Console.WriteLine(TreeNode.IsPerfect(root));

            Console.WriteLine("Kata Recursive");
            int numberFactorial = 6;
            Console.WriteLine($"The factorial of number {numberFactorial} is: {Recursion.FacCalculation(numberFactorial)}");

            Console.WriteLine("----Without Recursive");
            Console.WriteLine($"The factorial of number {numberFactorial} is:{Recursion.CalculateFactorial(numberFactorial)}");
        }
    }
}
