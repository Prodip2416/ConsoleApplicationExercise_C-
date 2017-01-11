using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListClassRange
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 9, 2, 6, 3, 7, 8, 0 };

            Console.WriteLine("Before the Sorting.......");

            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Sort();

            Console.WriteLine("After the Sorting.......");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Reverse();

            Console.WriteLine("Numbers in descending.......");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // For string.................................

            List<string> Alphabet = new List<string>() { "B", "M", "R", "A", "Z", "C" };

            Console.WriteLine("Before Sorting........");
            foreach(string str in Alphabet)
            {
                Console.WriteLine(str);
            }

            Alphabet.Sort();

            Console.WriteLine("After Sorting........");
            foreach (string str in Alphabet)
            {
                Console.WriteLine(str);
            }

            Alphabet.Reverse();

            Console.WriteLine("After Reversing........");
            foreach (string str in Alphabet)
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();

            //Customer C1 = new Customer() { Id = 101, Name = "Prodip", Salary = 8800, Type = "Customer" };
            //Customer C2 = new Customer() { Id = 102, Name = "Tuhin", Salary = 7700, Type = "CorporateCustomer" };
            //Customer C3 = new Customer() { Id = 103, Name = "Tamjid", Salary = 5500, Type = "Customer" };
            //Customer C4 = new Customer() { Id = 104, Name = "Joy", Salary = 4400, Type = "CorporateCustomer" };
            //Customer C5 = new Customer() { Id = 105, Name = "Akash", Salary = 6600, Type = "Customer" };
            //Customer C6 = new Customer() { Id = 106, Name = "Pavel", Salary = 5000, Type = "Customer" };

        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Salary { get; set; }
        public String Type { get; set; }
    }
}
