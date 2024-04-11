using CustomDataStructures.Dictionary;
using CustomDataStructures.Stack;

namespace DataStructuresPartII
{
    public class Program
    {
        public static void Main()
        {
            // PROBLEM 1
            string[] testInputs = { "()[]{}", "{[()]}", "(]", "({[)]}", "{[(])}", "{{[[(())]]}}" };
            
            foreach (var input in testInputs)
            {
                Console.WriteLine($"Is '{input}' balanced? {IsBalanced(input)}");
            }
            /*
            Is '()[]{}' balanced? True
            Is '{[()]}' balanced? True
            Is '(]' balanced? False
            Is '({[)]}' balanced? False
            Is '{[(])}' balanced? False
            Is '{{[[(())]]}}' balanced? True
             */

            // PROBLEM 2
            string text = "Hello world, hello code! Welcome to the world of code.";
            SimpleHashTable<string, int> frequencies = CountWords(text);
            frequencies.ListNodes();
            /*
            Bucket 0: (to, 1) (hello, 2)
            Bucket 1:
            Bucket 2: (welcome, 1)
            Bucket 3:
            Bucket 4: (of, 1)
            Bucket 5:
            Bucket 6: (world, 2)
            Bucket 7:
            Bucket 8: (the, 1) (code, 2)
            Bucket 9:
             */
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
    }
}
