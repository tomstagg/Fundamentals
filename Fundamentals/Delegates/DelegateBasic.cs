using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Delegates
{
    class DelegateBasic
    {
        public delegate void Del(string message);

        internal static void Run()
        {
            Del theDelegate = DelegateMethod;
            theDelegate += DelegateMethod;

            theDelegate("this is a delegate");
        }

        static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }
    }
}
