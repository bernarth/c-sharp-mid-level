namespace DataStruturesPartI;

public class MyStack<T>
{
    private StackNode<T> _topStack;

    public MyStack() 
    {
        _topStack = null;
    }

    public void AddStack(T stack)
    {
        var newStack = new StackNode<T>(stack);

        if (newStack == null )
        {
            _topStack = newStack;            
        }
        else
        {
            var stackIn = _topStack;
            _topStack = newStack;
            _topStack.Next = _topStack;            
        }
    }

    public void Pop()
    {    
        if (StackIsEmpty())
        {
            PrintStackEmpty();             
        }
        else
        {
            T value = _topStack.Data;
            _topStack = _topStack.Next;
            PrintStack(value);
        }        
    }

    public bool StackIsEmpty()
    {
        return _topStack == null;
    }

    public void PrintStackEmpty()
    {
        Console.WriteLine("Stack is empty");
    }

    public void PrintStack(T value)
    {
        Console.WriteLine(value);
    }
}
