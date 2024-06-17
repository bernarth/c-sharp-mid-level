using CustomDataStructures.Dictionary;
using CustomDataStructures.LinkedList;
using CustomDataStructures.Stack;
using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;

namespace DataStructuresPartII
{
    public class Program
    {
        public static void Main()
        {
            //private string _head;

            // PROBLEM 1
            string[] testInputs = { "()[]{}", "{[()]}", "(]", "({[)]}", "{[(])}", "{{[[(())]]}}" };

            foreach (var input in testInputs)
            {
                IsBalanced(input);
                Console.WriteLine($"Is '{input}' balanced? {IsBalanced(input)}");
            }

            Console.WriteLine("\n----------PROBLEM 2 ----------\n");

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

        public static SimpleHashTable<string, int> CountWords(string text)
        {
            var words = Regex.Matches(text.ToLower(),@"\b\w+\b").Cast<Match>().Select(m => m.Value);
            var hashTable = new SimpleHashTable<string, int>();
            
            foreach (var word in words)
            {
                if (hashTable.ContainsKey(word))
                {
                    var value = hashTable.Get(word)+1;
                    hashTable.Add(word, value);
                }
                else
                {
                    hashTable.Add(word, 1);
                }
            }

            return hashTable;
        }

        public static bool IsBalanced(string expression)
        {            
            var linked = new MyLinkedList<string>();
            
            foreach (var c in expression) 
            {
                linked.Add(c.ToString());    
            }

            return CheckBalance(linked);            
        }

        public static bool CheckBalance(MyLinkedList<string> linked)
        {
            bool flag = false;
            ListNode<string> current = linked.First();
            ListNode<string> last = linked.Last();
            ListNode<string> next = current.Next;          

            string start = current.Data.ToString();
            string end = DefineEnd(start);

            if (current.Data == start && last.Data == end)
            {
                flag = true;
            }
            while (current.Next != last) 
            {
                start = current.Data.ToString();
                end = DefineEnd(start);
                flag = false;

                if (current.Data == start && next.Data == end)
                {
                    current = next.Next;
                    next = next.Next.Next;
                    flag = true;
                }
                if (current.Data == start && last.Data == end)
                {
                    current = next;
                    next = next.Next;
                    last = last.Previous;                    
                    flag = true;
                }
                else
                {
                    break;
                }
            }        

            return flag;

        }

        public static string DefineEnd(string start)
        {
            string end = string.Empty;

            if (start == "(")
            {                
                end = ")";
            }
            if (start == "{")
            {                
                end = "}";
            }
            else if (start == "[")
            {                
                end = "]";
            }

            return end;
        }      
    }
}
