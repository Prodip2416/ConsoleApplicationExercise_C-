using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forAndForeachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNumbers = new int[3];
            myNumbers[0] = 100;
            myNumbers[1] = 101;
            myNumbers[2] = 102;

            for(int i = 0; i <= 200; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            //foreach(int k in myNumbers)
            //{
            //    Console.WriteLine(k);
            //}

            //for(int i = 0; i < myNumbers.Length; i++)
            //{
            //    Console.WriteLine(myNumbers[i]);
            //}
            //int j = 0;
            //while(j < myNumbers.Length)
            //{
            //    Console.WriteLine(myNumbers[j]);
            //    j++;
            //}


            Console.ReadLine();
        }
    }
}
