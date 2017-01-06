using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Conversion typr one,,,

            float f = 153.24F;

            int i = (int)f;
            Console.WriteLine(i);
            */

            /*
             // Type 2.....
            float f = 13.23F;
            int i = Convert.ToInt16(f);

            Console.WriteLine(i);
            */

            /*
            // Parse Method,,,,,,,,,
            string str = "132";

            int i = int.Parse(str);
            Console.WriteLine(i);
            */

            /*
             
            // In tryParse Method....Return a bool value.
            string str = "123GH";

            int i = 0;
            bool IsConversionSuccessfull = int.TryParse(str,out i);

            if(IsConversionSuccessfull== true)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine("Please Enter a valid number.");
            }
            */

            Console.ReadLine();
        }
    }
}
