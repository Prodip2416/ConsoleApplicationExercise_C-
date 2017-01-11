using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace ThreadingExampleeee
{
    class Program
    {
        static int Total = 0;
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            Thread T1 = new Thread(Program.AddOneMillion);
            Thread T2 = new Thread(Program.AddOneMillion);
            Thread T3 = new Thread(Program.AddOneMillion);
            T1.Start();
            T2.Start();
            T3.Start();

            T1.Join();
            T2.Join();
            T3.Join();

            Console.WriteLine("Total = " + Total);

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedTicks);


        }
        static object _lock = new object();
        public static void AddOneMillion()
        {
            Monitor.Enter(_lock);
            try
            {
                Total++;
            }
            finally
            {
                Monitor.Exit(_lock);
            }
        }
    }
}
