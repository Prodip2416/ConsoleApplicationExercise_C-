using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Customer[] customres = new Customer[3];

            customres[0] = new Customer()
            {
                Name = "Mark",
                Gender = Gender.Male
            };
            customres[1] = new Customer()
            {
                Name = "Marry",
                Gender = Gender.Female
            };
            customres[2] = new Customer()
            {
                Name = "Dom",
                Gender = Gender.Unknown
            };

            foreach (Customer customer in customres)
            {
                Console.WriteLine("Name = {0} and Gender = {1}", customer.Name, getGender(customer.Gender));
                Console.ReadLine();
            }
        }
 
        public static string getGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unknown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid data detected.";

            }
        }

    }

    // 0- Unknown
    // 1-Male
    // 2-Female

    public enum Gender
    {
        Male,
        Female,
        Unknown
    }
    public class Customer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }

    }
}
