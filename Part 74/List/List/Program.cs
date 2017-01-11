using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer() { Id = 101, Name = "Piter", Salary = 7500 };
            Customer C2 = new Customer() { Id = 102, Name = "Mark", Salary = 3400 };
            Customer C3 = new Customer() { Id = 103, Name = "Dom", Salary = 5500 };
            Customer C4 = new Customer() { Id = 104, Name = "Marry", Salary = 4500 };
            Customer C5 = new Customer() { Id = 105, Name = "Prodip", Salary = 8800 };

            List<Customer> customer = new List<Customer>(5);
            customer.Add(C1);
            customer.Add(C2);
            customer.Add(C3);
            customer.Add(C4);
            customer.Add(C5);

           // customer.Insert(0, C5);

            foreach (Customer cust in customer)
            {
                Console.WriteLine("Id= {0}, Name = {1}, Salary = {2}", cust.Id, cust.Name, cust.Salary);
            }
          
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
