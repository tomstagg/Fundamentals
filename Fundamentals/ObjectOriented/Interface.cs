using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    internal interface IInterface
    {
        void Hi(string message);
        string Name { get; set; }
    }

    class InterfaceClass : IInterface
    {
        public void Hi(string message)
        {
            Console.WriteLine(message);
        }
        public string Name { get; set; }

    }

    class Interface
    {
        public static void Run()
        {
            IInterface i = new InterfaceClass();

            i.Hi("interface");

        }
    }
}
