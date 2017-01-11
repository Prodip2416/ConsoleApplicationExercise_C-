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

            #region Array convert to Dictionary
     
            List<Customer> customer = new List<Customer>();
            customer.Add(C1);
            customer.Add(C2);
            customer.Add(C3);
            customer.Add(C4);
            customer.Add(C5);

            //Customer[] customer = new Customer[5];
            //customer[0] = C1;
            //customer[1] = C2;
            //customer[2] = C3;
            //customer[3] = C4;
            //customer[4] = C5;


            Dictionary<int, Customer> dict = customer.ToDictionary(cust => cust.Id, cust => cust);

            foreach (KeyValuePair<int, Customer>kvp in dict)
            {
                Console.WriteLine("key = {0}", kvp.Key);
                Customer cust = kvp.Value;
                Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", cust.Id, cust.Name, cust.Salary);
            }


            #endregion

            //Dictionary<int, Customer> DictionaryCustomer = new Dictionary<int, Customer>();
            //DictionaryCustomer.Add(C1.Id, C1);
            //DictionaryCustomer.Add(C2.Id, C2);
            //DictionaryCustomer.Add(C3.Id, C3);
            //DictionaryCustomer.Add(C4.Id, C4);
            //DictionaryCustomer.Add(C5.Id, C5);

            #region Remove & Clear
            //  DictionaryCustomer.Remove(104);
            // DictionaryCustomer.Clear();
            #endregion

            #region Count function Using......

            //Console.WriteLine("Total number = {0} ",DictionaryCustomer.Count(kvp=>kvp.Value.Name == "Prodip"));
            //Console.ReadLine();
            #endregion

            #region TryGetValue..........
            /*

            Customer cust;
            if(DictionaryCustomer.TryGetValue(105, out cust))
            {
                Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", cust.Id, cust.Name, cust.Salary);
            }
            else
            {
                Console.WriteLine("Key not found in Dicionary.");
            }
            */
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
