namespace CustomDataStructures.LinkedList;

public class LinkedList<T>
{
    private ListNode<T> _head;

    public LinkedList()
    {
        _head = null;
    }

    public void Add(T data)
    {
        if (_head == null)
        {
            _head = new ListNode<T>(data);
        }
        else
        {
            ListNode<T> current = _head;
            
            while (current.Next != null)
            {
                current = current.Next;
            }
            
            current.Next = new ListNode<T>(data);
        }
    }

    public bool Remove(T data)
    {
        ListNode<T> current = _head;
        ListNode<T> previous = null;

        while (current != null)
        {
            if (current.Data.Equals(data))
            {
                if (previous == null)
                {
                    _head = current.Next;
                }
                else
                {
                    previous.Next = current.Next;
                }
                
                return true;
            }

            previous = current;
            current = current.Next;
        }
        
        return false;
    }

    public void PrintAllNodes()
    {
        ListNode<T> current = _head;
        
        while (current != null)
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        }
    }
}
