using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegates
{
    public delegate void SampleDelegate();
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            SampleDelegate del1, del2, del3, del4;

            del1 = new SampleDelegate(SampleMethodOne);
            del2 = new SampleDelegate(SampleMethodTwo);
            del3 = new SampleDelegate(SampleMethodThree);

            del4 = del1 + del2 + del3 - del2;

            del4();

    */

            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del += SampleMethodTwo;
            del += SampleMethodThree;

            del();
        }
        public static void SampleMethodOne()
        {
            Console.WriteLine("Sample Method One.");
            Console.ReadLine();
        }

        public static void SampleMethodTwo()
        {
            Console.WriteLine("Sample Method Two.");
            Console.ReadLine();
        }

        public static void SampleMethodThree()
        {
            Console.WriteLine("Sample Method Three.");
            Console.ReadLine();
        }
    }
}
