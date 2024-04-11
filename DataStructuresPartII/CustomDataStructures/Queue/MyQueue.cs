namespace CustomDataStructures.Queue;

public class MyQueue<T>
{
    private QueueNode<T> _head;
    private QueueNode<T> _tail;

    public MyQueue()
    {
        _head = null;
        _tail = null;
    }

    public void Enqueue(T data)
    {
        var newNode = new QueueNode<T>(data);

        if (_tail == null)
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            _tail.Next = newNode;
            _tail = newNode;
        }
    }

    public T Dequeue()
    {
        if (_head == null)
        {
            Console.WriteLine("Queue is empty");
        }

        T value = _head.Data;
        _head = _head.Next;
        
        if (_head == null)
        {
            _tail = null;
        }
        
        return value;
    }

    public T Peek()
    {
        if (_head == null)
        {
            Console.WriteLine("Queue is empty");
        }

        return _head.Data;
    }

    public bool IsEmpty()
    {
        return _head == null;
    }
}
