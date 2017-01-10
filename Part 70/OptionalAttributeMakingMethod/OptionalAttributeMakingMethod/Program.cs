using System;
using System.Runtime.InteropServices;

namespace OptionalAttributeMakingMethod
{
    class Program
    {
       public static void Main(string[] args)
        {
            AddNumbers(10, 29);
        }
        public static void AddNumbers(int FirstNum, int LastNum, [OptionalAttribute] int[] restOfNumbers)
        {
            int result = FirstNum + LastNum;
            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine("Sum = {0}", result);
        }
    }
}
