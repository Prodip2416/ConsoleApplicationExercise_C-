using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> ListEmployes = new List<Employee>()
            {
                new Employee {Id=101, Name="Mark" },
                new Employee { Id = 102, Name = "Piter" }
            };

            Employee employee = ListEmployes.Find(emp=> emp.Id == 102);

            Console.WriteLine("Id = {0}, Name = {1}", employee.Id, employee.Name);

            int i = ListEmployes.Count(x => x.Name.StartsWith("P"));
            Console.WriteLine("Count = {0}", i);
        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
