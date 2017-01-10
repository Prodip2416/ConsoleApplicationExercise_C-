using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingToString
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number = 20;
            Console.WriteLine(number.ToString());

            Customer C1 = new Customer();
            C1.FirstName = "prodip";
            C1.LastName = "Sarker";

            Console.WriteLine(C1.ToString());

        }
    }

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set;}

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

    }
}
