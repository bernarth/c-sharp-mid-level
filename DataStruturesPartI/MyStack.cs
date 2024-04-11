namespace DataStruturesPartI;

public class MyStack<T>
{
    private StackNode<T> _top;

    public MyStack()
    {
        _top = null;
    }

    public void Push(T item)
    {
        var newNode = new StackNode<T>(item);

        if (_top == null)
        {
            _top = newNode;
        }
        else
        {
            var temp = _top;
            _top = newNode;
            _top.Next = temp;
        }
    }

    public T Pop()
    {
        if (_top == null)
        {
            Console.WriteLine("Stack is empty.");
        }

        T value = _top.Data;
        _top = _top.Next;

        return value;
    }

    public bool IsEmpty()
    {
        return _top == null;
    }
}
