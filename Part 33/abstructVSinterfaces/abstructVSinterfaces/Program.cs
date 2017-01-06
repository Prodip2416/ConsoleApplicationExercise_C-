using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstructVSinterfaces
{
    public abstract class Customer
    {
        public void Print()
        {
            Console.WriteLine("Print Method.");
            Console.ReadLine();
        }
    }
    public interface I1
    {
        void Print();
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
