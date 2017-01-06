using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExample
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    int i = 0;
        //    reference(ref i);
        //    Console.WriteLine(i);
        //    Console.ReadLine();
        //}

        ///// <summary>
        ///// Reference Type Examples.........
        ///// </summary>
        ///// <param name="j"></param>
        //public static void reference(ref int j)
        //{
        //    j = 102;
        //}


        //.........................................................................................................................................


        //public static void Main(string[] args)
        // {
        //     int Total = 0;
        //     int Product = 0;

        //     Calculate(10, 20, out Total, out Product);
        //     Console.WriteLine("Sum = {0}, Product ={1}", Total, Product);

        //     Console.ReadLine();
        // }

        // /// <summary>
        // /// out method types..........
        // /// </summary>
        // /// <param name="FN"></param>
        // /// <param name="LN"></param>
        // /// <param name="sum"></param>
        // /// <param name="product"></param>

        // public static void Calculate(int FN,int LN,out int sum,out int product)
        // {
        //     sum = FN + LN;
        //     product = FN * LN;
        // } 

        //......................................................................................................


        public static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;

            paramsMethid(numbers);
        }

        public static void paramsMethid(params int[] numbres)
        {
            Console.WriteLine("There ara {0} element.", numbres.Length);
            foreach(int i in numbres)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
