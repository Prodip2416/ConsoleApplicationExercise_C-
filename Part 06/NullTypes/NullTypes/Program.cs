using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool? areYouMajor = null;

            if(areYouMajor==true)
            {
                Console.WriteLine("User is Major.");
            }
            else if(areYouMajor==false)
            {
                Console.WriteLine("User Is not Major.");
            }
            else
            {
                Console.WriteLine("User is did not answer this question.");
            }

            Console.ReadLine();
        }
    }
}
