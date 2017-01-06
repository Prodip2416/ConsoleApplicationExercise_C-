using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchContinueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int totallPrice = 0;

            Start:
            Console.WriteLine("1-Small, 2-Medium, 3-large.");
            int UserChoice = int.Parse(Console.ReadLine());


            switch (UserChoice)
            {
                case 1:
                    totallPrice += 10;
                    break;
                case 2:
                    totallPrice += 20;
                    break;
                case 3:
                    totallPrice += 30;
                    break;
                default:
                    Console.WriteLine("Your Choice is invalid : {0}",UserChoice);
                    goto Start;
            }

            Decide:
            Console.WriteLine("Do you want to buy onther coffiee?  -Yes or  -No :");
            string UserSecondChoice = Console.ReadLine();

            switch (UserSecondChoice.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid.Please try again,,,,", UserSecondChoice);
                    goto Decide;
            }

            Console.WriteLine("Thanks.for your buying :)");
            Console.WriteLine("Your TotalBill : {0}", totallPrice);

            Console.ReadLine();
        }
    }
}
