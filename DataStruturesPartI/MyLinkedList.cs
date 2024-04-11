namespace DataStruturesPartI;

public class MyLinkedList<T>
{
    private LinkedNode<T> _current;
    private LinkedNode<T> _next;
    private LinkedNode<T> _previous;

    public MyLinkedList() 
    {
        _current = null;
    }

    public void Add(T data)    
    {
        var newLinked = new LinkedNode<T>(data);

        if (_current == null)
        {
            _current = newLinked;
        }
        else
        {
            //inseting new in current and moving current to previous
            _previous = _current;
            _current = newLinked;

            _current.Previous = _previous;
            _previous.Next = _current;
            
        }
    }

    public void PrintLinked()
    {
        LinkedNode<T> node = _current;

        while (node != null)
        {            
            Console.WriteLine(node.Data);
            node = node.Previous;
        }
    }
}
