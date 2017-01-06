using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        public static void Main(string[] args)
        {
            Add()
        }
        public static void Add(int FN,int SN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
            Console.ReadLine();
        }
        public static void Add(int FN, int SN,int TN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
          //  return FN + SN;
            
        }
    }
}
