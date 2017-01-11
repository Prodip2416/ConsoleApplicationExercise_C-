using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueCollectionClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer() { Id = 101, Name = "Piter", Gender = "Male" };
            Customer C2 = new Customer() { Id = 102, Name = "Marry", Gender = "FeMale" };
            Customer C3 = new Customer() { Id = 103, Name = "Dom", Gender = "FeMale" };
            Customer C4 = new Customer() { Id = 104, Name = "Mark", Gender = "Male" };
            Customer C5 = new Customer() { Id = 105, Name = "jack", Gender = "Male" };

            Queue<Customer> QueueCustomers = new Queue<Customer>();
            QueueCustomers.Enqueue(C1);
            QueueCustomers.Enqueue(C2);
            QueueCustomers.Enqueue(C3);
            QueueCustomers.Enqueue(C4);
            QueueCustomers.Enqueue(C5);


            foreach(Customer p in QueueCustomers)
            {
                Console.WriteLine("id = {0}, Name = {1}", p.Id, p.Name);
                Console.WriteLine("Total customer number = {0}", QueueCustomers.Count);
            }

            //Console.WriteLine("-------------------------------------------------");
            //Customer c= QueueCustomers.Dequeue();
            //Console.WriteLine("id = {0}, Name = {1}", c.Id, c.Name);
            //Console.WriteLine("Total customer number = {0}", QueueCustomers.Count);
            //Console.WriteLine("-------------------------------------------------");
            //Customer c1 = QueueCustomers.Dequeue();
            //Console.WriteLine("id = {0}, Name = {1}", c1.Id, c1.Name);
            //Console.WriteLine("Total customer number = {0}", QueueCustomers.Count);
            //Console.WriteLine("-------------------------------------------------");
            //Customer c2 = QueueCustomers.Dequeue();
            //Console.WriteLine("id = {0}, Name = {1}", c2.Id, c2.Name);
            //Console.WriteLine("Total customer number = {0}", QueueCustomers.Count);
            //Console.WriteLine("-------------------------------------------------");
            //Customer c3 = QueueCustomers.Dequeue();
            //Console.WriteLine("id = {0}, Name = {1}", c3.Id, c3.Name);
            //Console.WriteLine("Total customer number = {0}", QueueCustomers.Count);
            //Console.WriteLine("-------------------------------------------------");
            //Customer c4 = QueueCustomers.Dequeue();
            //Console.WriteLine("id = {0}, Name = {1}", c4.Id, c4.Name);
            //Console.WriteLine("Total customer number = {0}", QueueCustomers.Count);

            Console.ReadLine();
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

    }
}
