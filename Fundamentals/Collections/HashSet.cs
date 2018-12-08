using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals        
{
    class HashSetCollection
    {
        internal static void Run()
        {
            HashSet<int> set = new HashSet<int>();
            set.Add(1);
            set.Add(2);
            set.Add(2);

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            HashSet<Employee> employees = new HashSet<Employee>();

            Console.WriteLine("two seperate objects:");
            employees.Add(new Employee() { Name = "Tom" });
            employees.Add(new Employee() { Name = "Tom" });

            foreach (var item in employees)
            {
                Console.WriteLine($"\t{item.Name}");
            }

            Console.WriteLine("two references to the same object:");
            employees = new HashSet<Employee>();

            var employee = new Employee() { Name = "Em" };

            employees.Add(employee);
            employees.Add(employee);

            foreach (var item in employees)
            {
                Console.WriteLine($"\t{item.Name}");
            }

        }
    }
}
