using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodHiding
{
    public class Emplyee
    {
        public string FirstName;
        public string LastName;


        public void PrintFullName()
        {
            Console.WriteLine("{0}", FirstName + " " + LastName);
            Console.ReadLine();
        }
    }
    public class FullTimeEmplyee: Emplyee
    {
        public new void PrintFullName()
        {
            base.PrintFullName();
            //Console.WriteLine("{0}", FirstName + " " + LastName+"- Contractor");
            //Console.ReadLine();
        }
    }
    public class PartTimeEmplyee : Emplyee
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmplyee FTE = new FullTimeEmplyee();
            FTE.FirstName = "Full Time";
            FTE.LastName = "Emplyee";
            FTE.PrintFullName();

            PartTimeEmplyee PTE = new PartTimeEmplyee();
            PTE.FirstName = "Part Time";
            PTE.LastName = "Emplyee";
            PTE.PrintFullName();
        }
    }
}
