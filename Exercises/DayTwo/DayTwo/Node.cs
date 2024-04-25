using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DayTwo
{
    public partial class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            this.Data = data;
            this.Next = null;
        }

        public static Node GetNth(Node node, int index)
        {
            int count = 0;

            if (node == null || index > CountNodes(node))
            {
                throw new ArgumentException();
            }

            while(node != null)
            {
                if (count == index)
                {
                    return node;
                }

                node = node.Next;
                count++;
            }

            throw new ArgumentException();
        }

        public static int CountNodes(Node node)
        {
            int count = 0;

            while (node != null)
            {
                count++;
                node = node.Next;
                
            }

            return count;
        }
    }
}
