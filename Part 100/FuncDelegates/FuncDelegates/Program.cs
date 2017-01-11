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

           // Func<Employee, string> selector = employee => "Name =" + employee.Name;
            IEnumerable<string> names = ListEmployes.Select(employee => "Name =" + employee.Name);

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            // Console.WriteLine("Id = {0}, Name = {1}", employee.Id, employee.Name);



            Func<int, int, string> funcdelegate = (firstnum, seconnumber) => "Sum = " + (firstnum + seconnumber).ToString();
            string result = funcdelegate(10,34);
            Console.WriteLine(result);
        }
    
    }
    
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
