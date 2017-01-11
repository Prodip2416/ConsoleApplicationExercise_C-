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

            #region List to Dictionary

            List<Customer> Listcustomers = new List<Customer>(5);
            Listcustomers.Add(C1);
            Listcustomers.Add(C2);
            Listcustomers.Add(C3);
            Listcustomers.Add(C4);
            Listcustomers.Add(C5);

            Dictionary<int, Customer> dictionary = Listcustomers.ToDictionary(x => x.Id);

            foreach(KeyValuePair<int, Customer> kvp in dictionary)
            {
                Console.WriteLine("Key = {0}", kvp.Key);
                Customer c = kvp.Value;
                Console.WriteLine("id = {0}, Name = {1}, Salary = {2}", c.Id, c.Name, c.Salary);
            }
            Console.ReadLine();

            #endregion

            #region Array to List

            //Customer[] customerArray = new Customer[5];
            //customerArray[0] = C1;
            //customerArray[1] = C2;
            //customerArray[2] = C3;
            //customerArray[3] = C4;
            //customerArray[4] = C5;

            //List<Customer> ListCustomer = customerArray.ToList();

            //foreach(Customer c in ListCustomer)
            //{
            //    Console.WriteLine("id = {0}, Name = {1}, Salary = {2}", c.Id, c.Name, c.Salary);
            //}
            //Console.ReadKey();

            #endregion


            #region Find, FindAll, FindLast,,.........
            //List<Customer> Listcustomers = new List<Customer>(5);
            //Listcustomers.Add(C1);
            //Listcustomers.Add(C2);
            //Listcustomers.Add(C3);
            //Listcustomers.Add(C4);
            //Listcustomers.Add(C5);

            //int index = Listcustomers.FindIndex(cust => cust.Salary > 5000);
            //Console.WriteLine("Index = {0}", index);

            // //Find
            // Customer cust = Listcustomers.Find(c => c.Salary > 5000);
            // Console.WriteLine("id = {0}, Name = {1}, Salary = {2}", cust.Id, cust.Name, cust.Salary);
            // //FindLast
            // Customer cu = Listcustomers.FindLast(c => c.Salary > 5000);
            // Console.WriteLine("id = {0}, Name = {1}, Salary = {2}", cu.Id, cu.Name, cu.Salary);
            // Console.WriteLine("----------------------------------------------------");

            // List<Customer> customres = Listcustomers.FindAll(cc => cc.Salary > 5000);
            // //FindAll

            //foreach(Customer cus in customres)
            // {
            //     Console.WriteLine("id = {0}, Name = {1}, Salary = {2}", cus.Id, cus.Name, cus.Salary);

            // }
            // Console.ReadLine();
            #endregion

            #region Exists, Contains......
            //if(Listcustomers.Exists(cust=> cust.Name.StartsWith("D")))
            //if (Listcustomers.Contains(C4))
            //{
            //    Console.WriteLine("C5 is here.");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("C4 is not here.");
            //    Console.ReadLine();
            //}
            #endregion
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
