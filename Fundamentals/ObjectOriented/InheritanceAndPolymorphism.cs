using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    class BaseClass
    {
        public string Name = "BaseName";
        public virtual void Hi()
        {
            Console.WriteLine("BaseHi");
        }
    }

    class DerivedClass : BaseClass
    {
        public string AnotherName = "DerivedAnotherName";
        public override void Hi()
        {
            Console.WriteLine("DerivedHi");
        }
    }

    class InheritanceAndPolymorphism
    {
        public static void Run()
        {
            BaseClass bc = new BaseClass();
            Console.WriteLine("BaseClass Type and value of type BaseClass");
            Console.WriteLine(bc.Name);
            bc.Hi();
            Console.WriteLine();

            DerivedClass dc = new DerivedClass();
            Console.WriteLine("DerivedClass Type and value of type DerivedClass");
            Console.WriteLine(dc.Name);
            Console.WriteLine(dc.AnotherName);
            dc.Hi();
            Console.WriteLine();

            BaseClass bcdc = new DerivedClass();
            Console.WriteLine("BaseClass Type and value of type DerivedClass");
            Console.WriteLine(bcdc.Name);
            bcdc.Hi();
        }
    }
}
