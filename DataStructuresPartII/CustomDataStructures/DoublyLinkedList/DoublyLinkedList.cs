namespace CustomDataStructures.DoublyLinkedList;

public class DoublyLinkedList<T>
{
    private DoublyListNode<T> _head;
    private DoublyListNode<T> _tail;

    public DoublyLinkedList()
    {
        _head = null;
        _tail = null;
    }

    public void Add(T data)
    {
        var newNode = new DoublyListNode<T>(data);
        
        if (_head == null)
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            _tail.Next = newNode;
            newNode.Previous = _tail;
            _tail = newNode;
        }
    }

    public bool Remove(T data)
    {
        DoublyListNode<T> current = _head;
        
        while (current != null)
        {
            if (current.Data.Equals(data))
            {
                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    _head = current.Next;
                }
                
                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {
                    _tail = current.Previous;
                }
                
                return true;
            }
            
            current = current.Next;
        }

        return false;
    }

    public void PrintForward()
    {
        DoublyListNode<T> current = _head;

        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }

        Console.WriteLine();
    }

    public void PrintBackward()
    {
        DoublyListNode<T> current = _tail;

        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Previous;
        }

        Console.WriteLine();
    }
}
