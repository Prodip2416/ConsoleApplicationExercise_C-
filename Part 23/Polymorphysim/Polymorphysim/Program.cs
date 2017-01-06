using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphysim
{
    public class Emplyee
    {
        public string FirstName = "FN";
        public string LastName = "LN";

        public virtual void PrintFullName()
        {
            Console.WriteLine("{0}", FirstName + " " + LastName);
            Console.ReadLine();
        }
    }
    public class FullTimeEmplyee:Emplyee
    {
        public override void PrintFullName()
        {
            Console.WriteLine("{0}", FirstName + " " + LastName+"Full Time Emplyee");
            Console.ReadLine();
        }
    }
   public class PartTimeEmplyee : Emplyee
    {
        public override void PrintFullName()
        {
            Console.WriteLine("{0}", FirstName + " " + LastName+"Part Time Emplyee");
            Console.ReadLine();
        }
    }
    public class TemporeryEmplyee : Emplyee
    {
        public override void PrintFullName()
        {
            Console.WriteLine("{0}", FirstName + " " + LastName+"Temporery Emplyee");
            Console.ReadLine();
        }
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            Emplyee[] emplyess = new Emplyee[4];
            emplyess[0] = new Emplyee();
            emplyess[1] = new FullTimeEmplyee();
            emplyess[2] = new PartTimeEmplyee();
            emplyess[3] = new TemporeryEmplyee();
            

            foreach(Emplyee e in emplyess)
            {
                e.PrintFullName();
            }
        }
    }
}
