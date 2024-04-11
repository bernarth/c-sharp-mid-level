namespace CustomDataStructures.Dictionary;

public class SimpleHashTable<K, V>
{
    private HashNode<K, V>[] _buckets;
    private int _size;

    public SimpleHashTable(int size = 10)
    {
        _size = size;
        _buckets = new HashNode<K, V>[size];
    }

    private int GetBucketIndex(K key)
    {
        int hashCode = key.GetHashCode();
        int index = hashCode % _size;
        
        return Math.Abs(index);
    }

    public void Add(K key, V value)
    {
        int bucketIndex = GetBucketIndex(key);
        HashNode<K, V> newNode = new HashNode<K, V>(key, value);
        HashNode<K, V> head = _buckets[bucketIndex];

        // Check if key already exists
        HashNode<K, V> current = head;
        
        while (current != null)
        {
            if (current.Key.Equals(key))
            {
                current.Value = value; // Update value if key exists
                
                return;
            }
            
            current = current.Next;
        }

        // Insert new node
        newNode.Next = head;
        _buckets[bucketIndex] = newNode;
    }

    public V Get(K key)
    {
        int bucketIndex = GetBucketIndex(key);
        HashNode<K, V> head = _buckets[bucketIndex];

        while (head != null)
        {
            if (head.Key.Equals(key))
            {
                return head.Value;
            }
            
            head = head.Next;
        }

        return default; // Return default value for type V if key not found
    }

    public bool Remove(K key)
    {
        int bucketIndex = GetBucketIndex(key);
        HashNode<K, V> head = _buckets[bucketIndex];
        HashNode<K, V> previous = null;

        while (head != null)
        {
            if (head.Key.Equals(key))
            {
                if (previous == null) // The head node is the match
                {
                    _buckets[bucketIndex] = head.Next;
                }
                else
                {
                    previous.Next = head.Next;
                }
                
                return true;
            }
            
            previous = head;
            head = head.Next;
        }

        return false; // Key not found
    }

    public void ListNodes()
    {
        for (int i = 0; i < _size; i++)
        {
            HashNode<K, V> node = _buckets[i];
            Console.Write($"Bucket {i}: ");
            
            while (node != null)
            {
                Console.Write($"({node.Key}, {node.Value}) ");
                node = node.Next;
            }
            
            Console.WriteLine();
        }
    }

    public bool ContainsKey(K key)
    {
        int bucketIndex = GetBucketIndex(key);
        HashNode<K, V> head = _buckets[bucketIndex];

        while (head != null)
        {
            if (head.Key.Equals(key))
            {
                return true;
            }
            
            head = head.Next;
        }

        return false;
    }
}
