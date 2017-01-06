using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter 10,20,30 or any numbers: ");
            int UserNumber = int.Parse(Console.ReadLine());

            switch (UserNumber)
            {
                case 10:
                    Console.WriteLine("Your Numbers Is 10.");
                    break;
                case 20:
                    Console.WriteLine("Your numbers is 20.");
                    break;
                case 30:
                    Console.WriteLine("Your numbers is 30.");
                    break;
                default:
                    Console.WriteLine("Your Number is not 10,20 or 30. the numbers is :{0}", UserNumber);
                    break;
            }

                  Console.ReadLine();
        }
    }
}
