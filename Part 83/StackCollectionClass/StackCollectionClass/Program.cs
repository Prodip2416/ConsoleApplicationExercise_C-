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

            Stack<Customer> CustomerStack = new Stack<Customer>();

            CustomerStack.Push(C1);
            CustomerStack.Push(C2);
            CustomerStack.Push(C3);
            CustomerStack.Push(C4);
            CustomerStack.Push(C5);

            Customer c = CustomerStack.Peek();
            Console.WriteLine(c.Id + "-" + c.Name);
            Console.WriteLine("Item in stack = {0}", CustomerStack.Count);

            //foreach(Customer cc in CustomerStack)
            //{
            //    Console.WriteLine(cc.Id + "-" + cc.Name);
            //    Console.WriteLine("Item in stack = {0}", CustomerStack.Count);
            //}

            //Console.WriteLine("-------------------------------------");

            //Customer c = CustomerStack.Pop();
            //Console.WriteLine(c.Id + "-" + c.Name);
            //Console.WriteLine("Item in stack = {0}", CustomerStack.Count);
            //Console.WriteLine("-------------------------------------");

            //Customer c1 = CustomerStack.Pop();
            //Console.WriteLine(c1.Id + "-" + c1.Name);
            //Console.WriteLine("Item in stack = {0}", CustomerStack.Count);
            //Console.WriteLine("-------------------------------------");

            //Customer c2 = CustomerStack.Pop();
            //Console.WriteLine(c2.Id + "-" + c2.Name);
            //Console.WriteLine("Item in stack = {0}", CustomerStack.Count);
            //Console.WriteLine("-------------------------------------");

            //Customer c3 = CustomerStack.Pop();
            //Console.WriteLine(c3.Id + "-" + c3.Name);
            //Console.WriteLine("Item in stack = {0}", CustomerStack.Count);
            //Console.WriteLine("-------------------------------------");

            //Customer c4 = CustomerStack.Pop();
            //Console.WriteLine(c4.Id + "-" + c4.Name);
            //Console.WriteLine("Item in stack = {0}", CustomerStack.Count);


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

