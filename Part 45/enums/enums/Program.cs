using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enums
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Customer[] customres = new Customer[3];
           
            customres[0] = new Customer()
            {
                Name = "Mark",
                Gender = 1
            };
            customres[1] = new Customer()
            {
                Name = "Marry",
                Gender = 2
            };
            customres[2] = new Customer()
            {
                Name = "Dom",
                Gender = 0
            };

            foreach (Customer customer in customres)
            {
                Console.WriteLine("Name = {0} and Gender = {1}", customer.Name, getGender(customer.Gender));
                Console.ReadLine();
            }
        }
            public static string getGender(int gender)
             {
            switch (gender)
            {
                case 0:
                    return "Unknown";
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "Invalid data detected.";

            }
             }
        
    }

    // 0- Unknown
    // 1-Male
    // 2-Female

    public class Customer
    {
        public string Name  { get; set; }
        public int Gender { get; set; }

    }
}
