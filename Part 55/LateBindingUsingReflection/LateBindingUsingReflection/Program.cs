using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LateBindingUsingReflection
{
   public class Program
    {
        static void Main(string[] args)
        {
            Assembly executeAssembly = Assembly.GetExecutingAssembly();

            Type customerType = executeAssembly.GetType("Program.Customer");

           object customerInstance = Activator.CreateInstance(customerType);

            MethodInfo getFullNameMethod = customerType.GetMethod("GetFullName");

            string[] parameters = new string[2];
            parameters[0] = "Prodip";
            parameters[1] = "Technology";

           string FullName =(string)getFullNameMethod.Invoke(customerInstance, parameters);

        //    Customer C1 = new Customer();
        //    string fullName = C1.getFullName("Pragim", "Tech");
        //    Console.WriteLine("Full Name = {0}", fullName);
        //    Console.ReadLine();
        }
    }

    public class Customer
    {
        public string getFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
    }
}
