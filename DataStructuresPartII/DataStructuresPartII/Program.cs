using CustomDataStructures.Dictionary;
using CustomDataStructures.Stack;
using System.Text;

namespace DataStructuresPartII
{
    public class Program
    {
        public static void Main()
        {
            //// PROBLEM 1
            //string[] testInputs = { "()[]{}", "{[()]}", "(]", "({[)]}", "{[(])}", "{{[[(())]]}}" };

            //foreach (var input in testInputs)
            //{
            //    Console.WriteLine($"Is '{input}' balanced? {IsBalanced(input)}");
            //}
            ///*
            //Is '()[]{}' balanced? True
            //Is '{[()]}' balanced? True
            //Is '(]' balanced? False
            //Is '({[)]}' balanced? False
            //Is '{[(])}' balanced? False
            //Is '{{[[(())]]}}' balanced? True
            // */

            //// PROBLEM 2
            //string text = "Hello world, hello code! Welcome to the world of code.";
            //SimpleHashTable<string, int> frequencies = CountWords(text);
            //frequencies.ListNodes();
            ///*
            //Bucket 0: (to, 1) (hello, 2)
            //Bucket 1:
            //Bucket 2: (welcome, 1)
            //Bucket 3:
            //Bucket 4: (of, 1)
            //Bucket 5:
            //Bucket 6: (world, 2)
            //Bucket 7:
            //Bucket 8: (the, 1) (code, 2)
            //Bucket 9:
            // */

            string currentFormat = "He362? h55% l123.";
            //string[] result = Format(currentFormat);
            string numeros = "44225";
            Queue<int> queue = CreateQueue(numeros);
            string textReplaced = Replace(currentFormat, queue);
            Console.WriteLine(textReplaced);
            
        }

        public static bool IsBalanced(string expression)
        {
            return false;
        }

        public static SimpleHashTable<string, int> CountWords(string text)
        {
            var hashTable = new SimpleHashTable<string, int>();
            
            return hashTable;
        }

        public static string[] Format(string currentFormat)
        {
            string[] result = currentFormat.Split(' ');

            return result;
        }

        public static Queue<int> CreateQueue(string numeros)
        {
            var queue = new Queue<int>();            

            if(string.IsNullOrEmpty(numeros))
            {
                for (int i = 1; i <= 10; i++)
                {
                    queue.Enqueue(i%10);
                }
            }
            else
            {
                
                foreach (char digit in numeros)
                {
                    int currentNumber = int.Parse(digit.ToString());
                    queue.Enqueue(currentNumber);
                }
                
            }

            return queue;
        }

        public static string Replace(string current, Queue<int> queue)
        {
            StringBuilder textResult = new StringBuilder();
            //Queue<int> auxQueue = queue;
            foreach(char digit in current)
            {
                if (char.IsLetter(digit))
                {                    
                    int number = queue.Dequeue();
                    textResult.Append(number);
                    queue.Enqueue(number);
                }
                else
                {
                    textResult.Append(digit);
                }
            }

            string text = textResult.ToString();

            return text;
        }
    }
}
