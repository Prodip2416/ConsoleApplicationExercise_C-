using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structVSclass
{
    class Program
    {
        public class Customer
        {
            public int Id { get; set; }
            public string Nmae { get; set; }
        }
        static void Main(string[] args)
        {
            int i = 10;
            int j = i;
            j = j + 1;

            Console.WriteLine("i= {0} and j= {1}", i, j);
           

            Customer C1 = new Customer();
            C1.Id = 101;
            C1.Nmae = "Mark";

            Customer C2 = new Customer();
            C2.Nmae = "Mary";

            Console.WriteLine("C1.Name = {0} and C2.Name = {1}", C1.Nmae, C2.Nmae);
            Console.ReadLine();
        }
    }
}
