using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Calculator.Add(new List<int>() { 10, 20, 340 });
        }
    }

    public class Calculator
    {
        [Obsolete("Use Add(List<int> numbers) Methods")]
        public static int Add(int FirstNum,int LastNum)
        {
            return FirstNum + LastNum;
        }

        public static int Add(List<int> numbers)
        {
            int sum = 0;
            foreach(int number in numbers)
            {
                sum = sum + number;
            }
            return sum;
        }
    }
}
