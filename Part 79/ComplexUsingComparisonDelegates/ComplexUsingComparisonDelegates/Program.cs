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

            Console.WriteLine("Before Sorting...................");
            foreach(Customer c in ListCustomer)
            {
                Console.WriteLine("Id = {0}", c.Id);
            }

             ListCustomer.Sort((x,y) => x.Id.CompareTo(y.Id));
            //ListCustomer.Sort(delegate (Customer c, Customer cc) { return c.Id.CompareTo(cc.Id); });

            Console.WriteLine("After Sorting...................");
            foreach (Customer c in ListCustomer)
            {
                Console.WriteLine("Id = {0}", c.Id);
            }
            Console.ReadLine();
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
