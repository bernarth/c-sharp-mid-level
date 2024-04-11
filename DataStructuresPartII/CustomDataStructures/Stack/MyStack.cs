namespace CustomDataStructures.Stack;

public class MyStack<T>
{
    private StackNode<T> _top;

    public MyStack()
    {
        _top = null;
    }

    public void Push(T data)
    {
        var newNode = new StackNode<T>(data)
        {
            Next = _top
        };
        _top = newNode;
    }

    public T Pop()
    {
        if (_top == null)
        {
            Console.WriteLine("Stack is empty");
        }

        T value = _top.Data;
        _top = _top.Next;
        
        return value;
    }

    public T Peek()
    {
        if (_top == null)
        {
            Console.WriteLine("Stack is empty");
        }

        return _top.Data;
    }

    public bool IsEmpty()
    {
        return _top == null;
    }
}
