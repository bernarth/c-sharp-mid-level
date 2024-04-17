namespace Trees;

public class BinaryTreeNode<T> where T : struct, IComparable<T>
{
    public T Data { get; set; }

    public BinaryTreeNode<T> Left { get; set; }

    public BinaryTreeNode<T> Right { get; set; }

    public BinaryTreeNode(T data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}
