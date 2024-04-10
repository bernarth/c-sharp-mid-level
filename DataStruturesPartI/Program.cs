namespace DataStruturesPartI;

class Program
{
    public static void Main()
    {
        // Custom Queue
        var queue = new MyQueue<int>();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);

        var data = queue.Dequeue();

        Console.WriteLine("============Dequeue============");
        Console.WriteLine(data);

        while (!queue.IsEmpty())
        {
            Console.WriteLine(queue.Dequeue());
        }

        // Custom Stack
        var stack = new MyStack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Console.WriteLine("============Stack pop============");
        var dataStack = stack.Pop();
        Console.WriteLine(dataStack);

        var dataStack1 = stack.Pop();
        Console.WriteLine(dataStack1);

        var dataStack2 = stack.Pop();
        Console.WriteLine(dataStack2);

        stack.Push(4);
        stack.Push(5);
        stack.Push(6);

        while (!stack.IsEmpty())
        {
            Console.WriteLine(stack.Pop());
        }
    }
}
