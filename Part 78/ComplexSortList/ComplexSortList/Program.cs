using System;
using System.Collections.Generic;
using System.Linq;

namespace ListClassRange
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer() { Id = 101, Name = "Prodip", Salary = 8800, Type = "Customer" };
            Customer C2 = new Customer() { Id = 102, Name = "Tuhin", Salary = 7700, Type = "CorporateCustomer" };
            Customer C3 = new Customer() { Id = 103, Name = "Tamjid", Salary = 5500, Type = "Customer" };
            Customer C4 = new Customer() { Id = 104, Name = "Joy", Salary = 4400, Type = "CorporateCustomer" };
            Customer C5 = new Customer() { Id = 105, Name = "Akash", Salary = 6600, Type = "Customer" };
            Customer C6 = new Customer() { Id = 106, Name = "Pavel", Salary = 5000, Type = "Customer" };

            List<Customer> ListCustomer = new List<Customer>();
            ListCustomer.Add(C1);
            ListCustomer.Add(C2);
            ListCustomer.Add(C3);
            ListCustomer.Add(C4);
            ListCustomer.Add(C5);

            Console.WriteLine("Before sorting...........");
            foreach(Customer c in ListCustomer)
            {
                Console.WriteLine(c.Salary);
            }

            ListCustomer.Sort();

            Console.WriteLine("After sorting...........");
            foreach (Customer c in ListCustomer)
            {
                Console.WriteLine(c.Salary);
            }

            ListCustomer.Reverse();
            Console.WriteLine("After Reversing...........");
            foreach (Customer c in ListCustomer)
            {
                Console.WriteLine(c.Salary);
            }

            SortByName srt = new SortByName();
            Console.WriteLine("Before sorting Name...........");
            foreach (Customer c in ListCustomer)
            {
                Console.WriteLine(c.Name);
            }

            ListCustomer.Sort(srt);
            Console.WriteLine("After sorting Name...........");
            foreach (Customer c in ListCustomer)
            {
                Console.WriteLine(c.Name);
            }
            Console.ReadLine();
        }
    }

    public class SortByName : IComparer<Customer>
    {
        public int Compare(Customer x,Customer y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

    public class Customer: IComparable<Customer>

    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Salary { get; set; }
        public String Type { get; set; }

        public int CompareTo(Customer other)
        {
            return this.Salary.CompareTo(other.Salary);
        }
    }
}
