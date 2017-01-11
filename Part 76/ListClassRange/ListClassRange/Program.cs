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
            Customer C1 = new Customer() { Id = 101, Name = "Prodip", Salary = 8800, Type = "Customer" };
            Customer C2 = new Customer() { Id = 102, Name = "Tuhin", Salary = 7700, Type = "CorporateCustomer" };
            Customer C3 = new Customer() { Id = 103, Name = "Tamjid", Salary = 5500, Type = "Customer" };
            Customer C4 = new Customer() { Id = 104, Name = "Joy", Salary = 4400, Type = "CorporateCustomer" };
            Customer C5 = new Customer() { Id = 105, Name = "Akash", Salary = 6600, Type = "Customer" };
            Customer C6 = new Customer() { Id = 106, Name = "Pavel", Salary = 5000, Type = "Customer" };

            List<Customer> customer = new List<Customer>();
            customer.Add(C1);
            customer.Add(C3);
            customer.Add(C5);
            customer.Add(C6);

            List<Customer> CorporateCustomer = new List<Customer>();
            CorporateCustomer.Add(C2);
            CorporateCustomer.Add(C4);

            customer.AddRange(CorporateCustomer);
            foreach(Customer c in customer)
            {
                Console.WriteLine("id = {0}, Name = {1}, salary = {2}, Type = {3}", c.Id, c.Name, c.Salary, c.Type);
            }
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
