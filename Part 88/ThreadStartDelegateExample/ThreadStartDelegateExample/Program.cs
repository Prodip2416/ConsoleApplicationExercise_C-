using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadStartDelegateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread T1 = new Thread(new ThreadStart(Number.PrintNumber));
            T1.Start();
        }
    }
    class Number
    {
        public static void PrintNumber()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
