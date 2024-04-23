namespace Trees;

using System.Collections.Generic;

public class TreeNode<T> where T : struct, IComparable<T>
{
    public T Data { get; set; }

    public List<TreeNode<T>> Children { get; set; }

    public TreeNode<T> Parent { get; private set; }

    public TreeNode(T data)
    {
        Data = data;
        Children = new List<TreeNode<T>>();
    }

    public TreeNode<T> AddChildren(T data)
    {
        var node = new TreeNode<T>(data);
        Children.Add(node);
        node.Parent = this;

        return node;
    }

    public void Show()
    {
        var queue = new Queue<TreeNode<T>>();
        queue.Enqueue(this);

        while (queue.Count > 0)
        {
            var currentNode = queue.Dequeue();

            Console.WriteLine($"{currentNode.Data}");

            foreach ( var child in currentNode.Children )
            {
                // complete
            }
        }
    }
}