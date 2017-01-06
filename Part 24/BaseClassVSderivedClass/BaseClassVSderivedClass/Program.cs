using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClassVSderivedClass
{
    public class BaseClass
    {
        public virtual void print()
        {
            Console.WriteLine("I am base class print method.");
            Console.ReadLine();
        }
    }
    public class DerivedClass : BaseClass
    {
        public new void print()
        {
            Console.WriteLine("I am override class print method.");
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new DerivedClass();
            bc.print();

            DerivedClass dc = new DerivedClass();
            dc.print();
        }
    }
}
