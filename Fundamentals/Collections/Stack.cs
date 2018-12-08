using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    class StackCollection
    {
        internal static void Run()
        {
            Stack<Employee> employees = new Stack<Employee>();

            employees.Push(new Employee() { Name = "Tom" });
            employees.Push(new Employee() { Name = "Em" });
            employees.Push(new Employee() { Name = "Eva" });
            employees.Push(new Employee() { Name = "Seb" });

            while (employees.Count > 0)
            {
                var employee = employees.Pop();
                Console.WriteLine(employee.Name);
            }
        }
    }
}
