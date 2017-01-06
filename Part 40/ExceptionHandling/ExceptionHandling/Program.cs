using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader strdr = null;
            try
            {
                strdr = new StreamReader(@"E:\Programming With DOT NET\C# Console Application\PraGimTech Youtube\Part 40\Sample Files\Dataa.txt");
                Console.WriteLine(strdr.ReadToEnd());
                 //Console.ReadLine();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Please check if the file {0} exits.", ex.FileName);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // Console.ReadLine();
                //if(strdr != null)
                //{
                //    strdr.Close();
                //}
                //Console.WriteLine("Finally Block.");
                //   Console.ReadLine();
            }
            finally
            {
                strdr.Close();
                Console.WriteLine("Finally Block.");
                Console.ReadLine();
            }
        }
    }
}
