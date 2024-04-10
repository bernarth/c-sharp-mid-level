namespace DataStruturesPartI;

public class StackNode<T>
{
    public T Data { get; set; }

    public StackNode<T> Next { get; set; }

    public StackNode(T data)
    {
        Data = data;
        Next = null;
    }
}
