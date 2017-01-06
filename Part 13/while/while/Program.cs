using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your target: ");

            int UserNumber = int.Parse(Console.ReadLine());
            int Start = 0;

            while (Start< UserNumber)
            {
                Console.WriteLine(Start);
                Start = Start + 2;
            }
            Console.ReadLine();
        }
    }
}
