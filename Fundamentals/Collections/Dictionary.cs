using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    class DictionaryCollection
    {
        internal static void Run()
        {
            var employeesByName = new Dictionary<string, Employee>();

            employeesByName.Add("Tom", new Employee { Name = "Tom" });
            employeesByName.Add("Em", new Employee { Name = "Em" });
            employeesByName.Add("Seb", new Employee { Name = "Seb" });

            var tom = employeesByName["Tom"];

            foreach (var item in employeesByName)
            {
                Console.WriteLine($"{item.Key}:{item.Value.Name}");
            }

            var employeesByDepartment = new Dictionary<string, List<Employee>>();

            employeesByDepartment.Add("Engineering", new List<Employee> { new Employee { Name = "Tom" } });

            employeesByDepartment["Engineering"].Add(new Employee { Name = "Tom" });
            foreach (var item in employeesByDepartment)
            {
                foreach (var employee in item.Value)
                {
                    Console.WriteLine(employee.Name);
                }
            }
        }
    }
}
