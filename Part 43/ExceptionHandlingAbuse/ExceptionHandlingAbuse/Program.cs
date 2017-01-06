using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAbuse
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please inter a number.");
                int fn = int.Parse(Console.ReadLine());

                Console.WriteLine("Please inter a number.");
                int sn = int.Parse(Console.ReadLine());

                int result = fn / sn;

                Console.WriteLine("Result = {0}", result);
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid integer number");
                Console.ReadLine();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Only number between {0} and {1} are allowed.", int.MinValue,int.MaxValue);
                Console.ReadLine();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Denominator can not by Zero.");
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
