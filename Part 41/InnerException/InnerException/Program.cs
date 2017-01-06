using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter First number.");
                int FN = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter First number.");
                int Sn = Convert.ToInt32(Console.ReadLine());

                int result = FN / Sn;

                Console.WriteLine("Result = {0}", result);
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                string filepath = @"E:\Programming With DOT NET\C# Console Application\PraGimTech Youtube\Part 41\Sample Files";
                StreamWriter sw = new StreamWriter(filepath);
                sw.Write(ex.GetType().Name);
               // sw.WriteLine();
               sw.Write(ex.Message);
                sw.Close();
                Console.WriteLine("There is a problem, please try again later.");
               Console.ReadLine();
            }
        }
    }
}
