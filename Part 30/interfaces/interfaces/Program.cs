using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    interface I1
    {
        void Print();
    }
    interface I2
    {
        void I2Method();
    }
    public class Cutomer : I1, I2
    {
        public void Print()
        {
            Console.WriteLine("Interface print method.");
            Console.ReadLine();
        }
        public void I2Method()
        {
            Console.WriteLine("Interface I2 method.");
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cutomer C1 = new Cutomer();
            C1.I2Method();
        }
    }
}
