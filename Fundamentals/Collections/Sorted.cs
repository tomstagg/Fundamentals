using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    class SortedCollections
    {
        internal static void Run()
        {
            var employeesByName = new SortedList<string, List<Employee>>();

            employeesByName.Add("Sales", new List<Employee> { new Employee(), new Employee(), new Employee() });
            employeesByName.Add("Engineering", new List<Employee> { new Employee(), new Employee() });

            foreach (var item in employeesByName )
            {
                Console.WriteLine($"The count of employees for {item.Key} is {item.Value.Count}");
            }

            var set = new SortedSet<int>();
            set.Add(3);
            set.Add(1);
            set.Add(2);

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
