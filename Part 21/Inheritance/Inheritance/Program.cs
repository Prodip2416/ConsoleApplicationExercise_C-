using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Emplyee
    {
       public string FirstName;
       public string LastName;
       public string Salary;

        public void PrintFullName()
        {
            Console.WriteLine("Full Name = {0}", FirstName + " "+LastName);
            Console.ReadLine();
        }
    }
    public class FullTimeEmplyee : Emplyee
    {
        public float YearlySalary;
    }
    public class PartTimeEmplyee : Emplyee
    {
        public float HourlyRate;
    }
   public class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmplyee FTE = new FullTimeEmplyee();
            FTE.FirstName = "Prodip";
            FTE.LastName = "Sarker";
            FTE.YearlySalary = 200000;
            FTE.PrintFullName();

            PartTimeEmplyee PTE = new PartTimeEmplyee();
            PTE.FirstName = "Tuhin";
            PTE.LastName = "Al Jobaed";
            PTE.HourlyRate = 100;
            PTE.PrintFullName();

        }
    }
}
