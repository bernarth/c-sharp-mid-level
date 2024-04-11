namespace CustomDataStructures.DoublyLinkedList;

public class DoublyListNode<T>
{
    public T Data { get; set; }

    public DoublyListNode<T> Next { get; set; }
    
    public DoublyListNode<T> Previous { get; set; }

    public DoublyListNode(T data)
    {
        Data = data;
        Next = null;
        Previous = null;
    }
}
