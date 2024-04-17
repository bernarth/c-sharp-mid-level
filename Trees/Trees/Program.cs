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

    }
}
