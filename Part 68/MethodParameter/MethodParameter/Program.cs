using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodParameter
{
    class Program
    {
       public static void Main(string[] args)
        {
            AddNumbers(10, 20,new int[] { 40,30});
        }
        public static void AddNumbers(int FirstNum, int LastNum)
        {
            AddNumbers(FirstNum, LastNum, null);
        }
        public static void AddNumbers(int FirstNum, int LastNum, params object[] restOfNumbers)
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
