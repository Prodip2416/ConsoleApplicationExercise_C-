using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingAndWriting
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please Enter Your FirstName:");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Please Enter Your LastName:");
            string LastName = Console.ReadLine();

            // Console.WriteLine("Hello, " + UserName);

            Console.WriteLine("Hello, {0} {1}", FirstName,LastName); // Most preferred Way.

            Console.ReadLine();
        }
    }
}
