using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    class LinkedListCollection
    {
        internal static void Run()
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddFirst(2);
            list.AddFirst(3);

            var first = list.First;

            list.AddAfter(first, 5);
            list.AddBefore(first, 10);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Node value:");
            var node = list.First;
            while (node != null)
            {
                Console.WriteLine("\t" + node.Value);
                node = node.Next;
            }
        }
    }
}
