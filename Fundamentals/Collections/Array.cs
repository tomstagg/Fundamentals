using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    class ArrayFundamentals
    {
        public static void Run()
        {
            //array
            Employee[] employees = new Employee[] {
                new Employee { Name = "Tom"},
                new Employee { Name = "Em"},
            };

            foreach (var employee in employees)
	        {
                Console.WriteLine(employee.Name);
    	    }

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(employees[i].Name);
            }
        }
    }
}
 