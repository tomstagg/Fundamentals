using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Generics
{
    class CircularBufferUserInput
    {
        internal static void Run()
        {
            //var buffer = new CircularBuffer<int>(capacity: 3);
            var buffer = new Buffer<int>();
            //var buffer = new CircleBufferNonGeneric(capacity: 3);

            ProcessInput(buffer);
            //buffer.Write("hello");

            ProcessBuffer(buffer);
        }
        private static void ProcessBuffer(IBuffer<int> buffer)
        {
            var sum = 0;
            Console.WriteLine("Buffer: ");
            while (!buffer.IsEmpty)
            {
                var result = buffer.Read();
                Console.WriteLine("\t" + result);
                sum += result;
            }
            Console.WriteLine(sum);
        }

        private static void ProcessInput(IBuffer<int> buffer)
        {
            Console.WriteLine("Input into the buffer:");
            while (true)
            {
                var value = 0;
                var input = Console.ReadLine();

                if (int.TryParse(input, out value))
                {
                    buffer.Write(value);
                    continue;
                }
                break;
            }
        }
    }
}
