using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruturesPartI;

internal class MyStack<T>
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

    public T Pop()
    {
        T value = default;

        if (StackIsEmpty())
        {
            Console.WriteLine("Stack is empty");            
        }
        else
        {
            value = _topStack.Data;
            _topStack = _topStack.Next;
        }     

        return value;
    }

    public bool StackIsEmpty()
    {
        return _topStack == null;
    }
}
