using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter 10 ,20,30 or any numbers: ");
            int num1 = int.Parse(Console.ReadLine());

            if(num1 ==10)
            {
                Console.WriteLine("Number is 10.");
            }
            else if(num1 == 20)
            {
                Console.WriteLine("Number is 20.");
            }
            else if(num1 == 30)
            {
                Console.WriteLine("Your Number is 30.");
            }
            else
            {
                Console.WriteLine("Your Number is not 10,20 or 30. the numbers is  {0}.", num1);
            }

            Console.ReadLine();
        }
    }
}
