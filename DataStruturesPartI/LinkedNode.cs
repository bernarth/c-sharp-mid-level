namespace DataStruturesPartI;

public class LinkedNode<T>
{
    public T Data { get; set; }
    public LinkedNode<T> Next { get; set; }
    public LinkedNode<T> Previous { get; set; }
    public LinkedNode(T data)
    {
        Data = data;
        Next = null;
        Previous = null;
    }
}
