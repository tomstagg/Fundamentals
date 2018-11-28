using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    class ListCollection
    {
        public static void Run()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() {Name = "Eva"},
                new Employee() { Name = "Seb"}
            };

            employees.Add(new Employee() { Name = "Em" });

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Name);
            }

            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i].Name);
            }

            // List Capacity
            var numbers = new List<int>(10); //list with starting capacity
            var capacity = -1;

            while (true) {

                if (numbers.Capacity != capacity)
                {
                    capacity = numbers.Capacity;
                    Console.WriteLine(numbers.Capacity);
                }
                numbers.Add(1);
            }
        }
    }
}
