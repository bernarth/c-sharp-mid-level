using System.Xml.Linq;

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

    public bool Find(T data)
    {
        return Find(Root, data);
    }

    private static bool Find(BinaryTreeNode<T> node, T data)
    {
        if (node == null)
        {
            return false;
        }
        else if (data.CompareTo(node.Data) < 0)
        {
            return Find(node.Left, data);
        }
        else if (data.CompareTo(node.Data) > 0)
        {
            return Find(node.Right, data);
        }
        else
        {
            return true;
        }
    }

    public void BreadthFirstSearchQueue()
    {
        if (Root == null)
        {
            return;
        }

        var queue = new Queue<BinaryTreeNode<T>>();
        queue.Enqueue(Root);

        while (queue.Count > 0)
        {
            var currentNode = queue.Dequeue();

            Console.Write($"{currentNode.Data} ");

            if (currentNode.Left != null)
            {
                queue.Enqueue(currentNode.Left);
            }

            if (currentNode.Right != null)
            {
                queue.Enqueue(currentNode.Right);
            }
        }
    }

    public void BreadthFirstSearchStack()
    {
        if (Root == null)
        {
            return;
        }

        var stack = new Stack<BinaryTreeNode<T>>();
        stack.Push(Root);

        while (stack.Count > 0)
        {
            var currentNode = stack.Pop();

            Console.Write($"{currentNode.Data} ");

            if (currentNode.Left != null)
            {
                stack.Push(currentNode.Left);
            }

            if (currentNode.Right != null)
            {
                stack.Push(currentNode.Right);
            }
        }
    }
}
