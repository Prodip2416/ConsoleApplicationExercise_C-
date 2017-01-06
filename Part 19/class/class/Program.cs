using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cs = new Customer("Prodip", "Sarker");
            cs.PrintFullName();

        }
    }
    class Customer
    {
        string _FirstName;
        string _LastName;
        public Customer(string FirstName, string LastName)
        {
            this._FirstName = FirstName;
            this._LastName = LastName;
        }
        public void PrintFullName()
        {
            Console.WriteLine("Full Name = {0}", this._FirstName + " " + this._LastName);
            Console.ReadLine();
        }
        ~Customer()
        {
            //Clean up code.
        }
    }
}
