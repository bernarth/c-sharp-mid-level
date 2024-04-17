namespace Trees;

public class BinaryTree<T> where T : struct, IComparable<T>
{
    public BinaryTreeNode<T> Root { get; set; }

    public BinaryTree(T rootData)
    {
        Root = new BinaryTreeNode<T>(rootData);
    }

    public void Add(T data)
    {
        Root = Insert(Root, data);
    }

    public BinaryTreeNode<T> Insert(BinaryTreeNode<T> node, T data)
    {
        if (node == null)
        {
            node = new BinaryTreeNode<T>(data);
        }
        else if (data.CompareTo(node.Data) < 0)
        {
            node.Left = Insert(node.Left, data);
        }
        else
        {
            node.Right = Insert(node.Right, data);
        }

        return node;
    }

    public void PrintInOrder(BinaryTreeNode<T> node)
    {
        if (node != null)
        {
            PrintInOrder(node.Left);
            Console.Write($"{node.Data} ");
            PrintInOrder(node.Right);
        }
    }

    public void PrintPreOrder(BinaryTreeNode<T> node)
    {
        if (node != null)
        {
            Console.Write($"{node.Data} ");
            PrintPreOrder(node.Left);
            PrintPreOrder(node.Right);
        }
    }

    public void PrintPostOrder(BinaryTreeNode<T> node)
    {
        if (node != null)
        {
            PrintPostOrder(node.Left);
            PrintPostOrder(node.Right);
            Console.Write($"{node.Data} ");
        }
    }
}
