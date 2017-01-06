using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To DataType In C#.\n\n\n\n");

            bool t = true;
            bool f = false;

            // Bool are only two those value.
            Console.WriteLine("Bool 1st = {0}",t);
            Console.WriteLine("Bool 2nd = {0}\n", f);

            // Integral Min and Max value
            Console.WriteLine("Integral Min Value = {0}", int.MinValue);
            Console.WriteLine("Integral Max Value = {0}\n",int.MaxValue);

            // Floating point Min and Max Value
            Console.WriteLine("Floating Point Min Value = {0}", float.MinValue);
            Console.WriteLine("Floating Point Max Value = {0}\n", float.MaxValue);

            // Double Min and Max Value
            Console.WriteLine("Double Min Value = {0}", double.MinValue);
            Console.WriteLine("Double Max Value = {0}\n", double.MaxValue);

            // Decimal Min and Max Value         
            Console.WriteLine("Decimal Min Value = {0}", decimal.MinValue);
            Console.WriteLine("Decimal Max Value = {0}\n", decimal.MaxValue);

            Console.ReadLine();
        }
    }
}
