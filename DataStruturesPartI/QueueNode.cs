namespace DataStruturesPartI;

public class QueueNode<T>
{
    public T Data { get; set; }

    public QueueNode<T> Next { get; set; }

    public QueueNode(T data)
    {
        Data = data;
        Next = null;
    }
}
