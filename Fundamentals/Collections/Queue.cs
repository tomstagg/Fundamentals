using System.Collections.Generic;

namespace Fundamentals
{
    class QueueCollection
    {
        public static void Run()
        {
            Queue<Employee> line = new Queue<Employee>();
            line.Enqueue(new Employee { Name = "Tom" });
            line.Enqueue(new Employee { Name = "Emma" });
            line.Enqueue(new Employee { Name = "Eva" });
            line.Enqueue(new Employee { Name = "Seb" });

            while (line.Count > 0)
            {
                var employee = line.Dequeue();
                System.Console.WriteLine(employee.Name);
            }

        }
    }
}
