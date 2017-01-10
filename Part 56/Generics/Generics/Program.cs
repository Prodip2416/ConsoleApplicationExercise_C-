using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool Equal = Calculator.AraEqual<string>("AB", "AB");

            if (Equal)
            {
                Console.WriteLine("Equal.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Not Equal.");
                Console.ReadLine();
            }
        }
    }

    public class Calculator
    {
        public static bool AraEqual<T>(T value1,T value2)
        {
            return value1.Equals(value2);
        }
    }
}
