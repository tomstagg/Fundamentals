using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public abstract class AbstractClass
    {
        public abstract void Hi(string message);
        public string Name { get; set; }
    }

    class ConcreteClass : AbstractClass
    {
        public override void Hi(string message)
        {
            Console.WriteLine(message);
        }
    }

    class Abstract
    {
        public static void Run()
        {
            AbstractClass ab = new ConcreteClass();
            ab.Hi("Hi there");

            ab.Name = "AName";

        }
    }
}

