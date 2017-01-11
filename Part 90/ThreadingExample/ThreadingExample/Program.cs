using System;
using System.Threading;
namespace ThreadingExample
{
    class Program
    {
        public static void Main()
        {
            
            Console.WriteLine("Please enter the target number");
            int target = Convert.ToInt32(Console.ReadLine());

            // Create an instance of the Number class, passing it
            // the target number that was read from the console
            Number number = new Number(target);
            // Specify the Thread function
            Thread T1 = new Thread(new ThreadStart(number.PrintNumbers));
            // Alternatively we can just use Thread class constructor as shown below
            // Thread T1 = new Thread(number.PrintNumbers);
            T1.Start();
        }
    }
    class Number
    {
        int _target;
        /
        public Number(int target)
        {
            // The targer number is then stored in the class private variable _target
            this._target = target;
        }

        // Function prints the numbers from 1 to the traget number that the user provided
        public void PrintNumbers()
        {
            for (int i = 1; i <= _target; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

