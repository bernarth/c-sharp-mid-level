namespace CustomDataStructures.LinkedList;

public class MyLinkedList<T>
{
    private ListNode<T> _head;
    private ListNode<T> _next;
    private ListNode<T> _previous;  

    public MyLinkedList()
    {
        _head = null;
    }

    public void Add(T data)
    {
        var newNode = new ListNode<T>(data);

        if (_head == null)
        {
            _head = newNode;
        }
        else
        {
            _previous = _head;
            _head = newNode;

            _head.Previous = _previous;
            _previous.Next = _head;            
        }
    }

    public ListNode<T> Find(T data)
    {
        ListNode<T> result = _head;
        ListNode<T> node = _head;

        while (node != null)
        {
            if (node.Data.Equals(data))
            {
                result = node;
            }
            node = node.Previous;
        }

        return result;
    }

    public void Remove(T data)
    {
        ListNode<T> result = Find(data);

        if (result != null)
        {
            var previus = result.Previous;
            var next = result.Next;

            if (previus != null)
            {
                previus.Next = next;
            }

            if (next != null)
            {
                next.Previous = previus;
            }
        }
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

    public ListNode<T> Last()
    {
        ListNode<T> last = _head;       

        return last;        
    }

    public ListNode<T> First()
    {
        ListNode<T> first = _head;

        while (first.Previous != null)
        {
            first = first.Previous;
        }

        return first;
    }
}
