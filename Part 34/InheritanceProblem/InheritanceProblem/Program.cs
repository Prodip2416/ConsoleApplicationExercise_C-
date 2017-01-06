using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProblem
{
    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("Class A Implenmentation.");
            Console.ReadLine();
        }
    }
    class B:A
    {
        public override void Print()
        {
            Console.WriteLine("Class B Override Implenmentation.");
            Console.ReadLine();
        }
    }
    class C:A
    {
        public virtual void Print()
        {
            Console.WriteLine("Class C Override  Implenmentation.");
            Console.ReadLine();
        }
    }
    // can not inherite two or many class at the same time
    // class D:B,C   
    //This is not currect
    class D : B
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            D d = new D();
            d.Print();
        }
    }
}
