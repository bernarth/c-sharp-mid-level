namespace Trees;

public class Program
{
    static void Main()
    {
        // Binary Tree
        var binaryTree = new BinaryTree<int>(5);
        binaryTree.Add(1);
        binaryTree.Add(2);
        binaryTree.Add(3);
        binaryTree.Add(4);
        binaryTree.Add(6);
        binaryTree.Add(7);
        binaryTree.Add(8);
        binaryTree.PrintPreOrder(binaryTree.Root);
        Console.WriteLine();
        binaryTree.PrintInOrder(binaryTree.Root);
        Console.WriteLine();
        binaryTree.PrintPostOrder(binaryTree.Root);

        // Binary Search
        var secondBinaryTree = new BinaryTree<int>(1);
        secondBinaryTree.Add(4);
        secondBinaryTree.Add(5);
        secondBinaryTree.Add(67);
        secondBinaryTree.Add(2);
        secondBinaryTree.Add(23);
        secondBinaryTree.Add(45);
        secondBinaryTree.Add(12);
        secondBinaryTree.Add(14);

        Console.WriteLine();
        secondBinaryTree.PrintPreOrder(secondBinaryTree.Root);
        Console.WriteLine($"\nDoes 5 exist? {secondBinaryTree.Find(5)}");
        Console.WriteLine($"Does 100 exist? {secondBinaryTree.Find(100)}");

        // BFS
        binaryTree.BreadthFirstSearchQueue();
        Console.WriteLine();
        binaryTree.BreadthFirstSearchStack();

        // N-ary tree
        var tree = new TreeNode<int>(0);
        tree.AddChildren(1)
                .AddChildren(2)
                    .AddChildren(3)
                        .AddChildren(4)
                            .Parent
                        .AddChildren(5)
                            .Parent
                        .Parent
                    .AddChildren(6)
                        .Parent
                    .AddChildren(7)
                        .Parent
                    .AddChildren(8);

        // Complete the Show method
        Console.WriteLine("\nShow method");
        tree.Show();

        // Implement the Find method
        Console.WriteLine($"Does 4 exist?: {tree.Find(4)}");
        Console.WriteLine($"Does 8 exist?: {tree.Find(8)}");
        Console.WriteLine($"Does 9 exist?: {tree.Find(9)}");
    }
}
