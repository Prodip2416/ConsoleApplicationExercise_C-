using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateExampleUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Emplyee> empList = new List<Emplyee>();

          empList.Add(new Emplyee() { Id = 101, Name = "Mark", Salary = 10000,Experience = 5 });
            empList.Add(new Emplyee() { Id = 102, Name = "Mary", Salary = 10000, Experience = 4 });
            empList.Add(new Emplyee() { Id = 103, Name = "Dom", Salary = 10000, Experience = 6 });
            empList.Add(new Emplyee() { Id = 104, Name = "Piter", Salary = 10000, Experience = 4 });
            empList.Add(new Emplyee() { Id = 105, Name = "Jerry", Salary = 10000, Experience = 5  });


            Emplyee.PromoteEmplyee(empList);
        }
    }
   class Emplyee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }


        public static void PromoteEmplyee(List<Emplyee> EmplyeeList)
        {
            foreach(Emplyee emplyee in EmplyeeList)
            {
                if(emplyee.Experience <= 5)
                {
                    Console.WriteLine(emplyee.Name + " Promoted");
                    Console.ReadLine();
                }
            }
        }
    }
}
