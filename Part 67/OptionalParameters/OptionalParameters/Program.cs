using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class Program
    {
        public static void Main(string[] args)
        {
        }

        public static void AddNumbers(int FirstNum,int LastNum,params object[] restOfNumbers)
        {
            int result = FirstNum + LastNum;
            if(restOfNumbers != null)
            {
                foreach(int i in restOfNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine("Sum = {0}", result);
        }
    }
}
