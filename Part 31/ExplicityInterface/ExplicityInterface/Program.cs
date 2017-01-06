using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicityInterface
{
    interface I1
    {
       void interfaceMethod();
    }
    interface I2
    {
        void interfaceMethod();
    }
    class Program:I1,I2
    {
        void I1.interfaceMethod()
        {
            Console.WriteLine("I1 interface method.");
            Console.ReadLine();
        }
        void I2.interfaceMethod()
        {
            Console.WriteLine("I2 interface method.");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            ((I1)p).interfaceMethod();
            ((I2)p).interfaceMethod();
        }
    }
}
