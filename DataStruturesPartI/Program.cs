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

        Console.WriteLine(data);

        while (!queue.IsEmpty())
        {
            Console.WriteLine(queue.Dequeue());
        }

        // Custom Stack
        var stack = new MyStack<int>();

        stack.AddStack(0);
        stack.AddStack(2);
        stack.AddStack(3);
        stack.AddStack(4);
        stack.AddStack(8);

        stack.Pop();

    }
}
