using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    public delegate void HelloFunctionDelegate(string message);
    class Program
    {
        public static void Main(string[] args)
        {
            //A Delegates is a type safe function pointer.
            HelloFunctionDelegate hfd = new HelloFunctionDelegate(Hello);
            hfd("Hello from delegate.");
        }

        public static void Hello (string strMesssage)
        {
            Console.WriteLine(strMesssage);
            Console.ReadLine();
        }

    }
}
