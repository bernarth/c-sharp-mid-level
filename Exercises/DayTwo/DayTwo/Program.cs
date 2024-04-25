namespace DayTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = TreeNode.Leaf().WithLeaves();
            Console.WriteLine(TreeNode.IsPerfect(root));
            
        }
    }
}
