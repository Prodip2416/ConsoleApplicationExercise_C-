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

            // Predicate<Employee> predicateEmployee = new Predicate<Employee>(FindEmployee);

            // Anonymous method......delegates.....
            // only 2 line of code.....

            // ListEmployes.Find(delegate(Employee emp) { return emp.Id == 102; } )

            Employee employee = ListEmployes.Find(delegate(Employee emp) { return emp.Id == 102; } );

            Console.WriteLine("Id = {0}, Name = {1}", employee.Id, employee.Name);
        }
        //public static bool FindEmployee(Employee emp)
        //{
        //    return emp.Id == 102;
        //}
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
