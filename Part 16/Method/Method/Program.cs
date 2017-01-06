using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
      public static void Main(string[] args)
        {
            //static,,,
            Program.EvenNumbers(50);

            // instance method,,,,,,,,,
            Program p = new Program();
            int sum = p.Add(23, 24);

            Console.WriteLine("Sum is = {0}", sum);
        }

        /// <summary>
        /// instance method,,,,,,,
        /// </summary>
        public int Add(int a,int b)
        {
            return a + b;
        }


        /// <summary>
        /// Static method,,,,,,,,
        /// </summary>
         public static void EvenNumbers(int target)
        {
            int start = 0;

            while (start <= target)
            {
                Console.WriteLine(start);
                start +=2;
            }

            Console.ReadLine();
        }
    }
}
