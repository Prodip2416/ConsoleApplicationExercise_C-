using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClass
{
    public abstract class Customer
    {
       public abstract void Print();
    }
    class Program:Customer
    {
        public override void Print()
        {
            Console.WriteLine("print Method");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Print();
        }
    }
}
