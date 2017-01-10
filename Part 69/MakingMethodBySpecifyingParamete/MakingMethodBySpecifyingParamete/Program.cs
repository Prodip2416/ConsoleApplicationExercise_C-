using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingMethodBySpecifyingParamete
{
    class Program
    {
        public static void Main(string[] args)
        {
            AddNumbers(10, 20, new int[] { 30, 40 });
        }
        public static void AddNumbers(int FirstNum, int LastNum,int[] restOfNumbers=null)
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
