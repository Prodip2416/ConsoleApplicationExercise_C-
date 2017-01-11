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
            Customer C1 = new Customer() { Id=101, Name="Piter",Salary=7500};
            Customer C2 = new Customer() { Id = 102, Name = "Mark", Salary = 3400 };
            Customer C3 = new Customer() { Id = 103, Name = "Dom", Salary = 5500 };
            Customer C4 = new Customer() { Id = 104, Name = "Marry", Salary = 4500 };
            Customer C5 = new Customer() { Id = 105, Name = "Prodip", Salary = 8800 };

            Dictionary<int, Customer> DictionaryCustomer = new Dictionary<int, Customer>();
            DictionaryCustomer.Add(C1.Id, C1);
            DictionaryCustomer.Add(C2.Id, C2);
            DictionaryCustomer.Add(C3.Id, C3);
            DictionaryCustomer.Add(C4.Id, C4);
            DictionaryCustomer.Add(C5.Id, C5);

             // Customer cusDetails1 = DictionaryCustomer[102];
             //Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", cusDetails1.Id, cusDetails1.Name, cusDetails1.Salary);

           // foreach (KeyValuePair<int, Customer> customerKeyValuePair in DictionaryCustomer)
           foreach(Customer cust in DictionaryCustomer.Values)
            {
                //Console.WriteLine("Key = {0}", customerKeyValuePair.Key);
                //Customer cust = customerKeyValuePair.Value;
                Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", cust.Id, cust.Name, cust.Salary);
                Console.WriteLine("-------------------------------------------------------------");
            }
            Console.ReadLine();
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
