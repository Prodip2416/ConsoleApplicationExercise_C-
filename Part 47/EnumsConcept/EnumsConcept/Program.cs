using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsConcept
{
    class Program
    {
        static void Main(string[] args)
        {


            short[] values = (short[])Enum.GetValues(typeof(Gander));

            foreach (int value in values)
            {
                Console.WriteLine(value);
                Console.ReadLine();
            }

            string[] Names = Enum.GetNames(typeof(Gander));

            foreach (string name in Names)
            {
                Console.WriteLine(name);
                Console.ReadLine();
            }
        }
    }
}

public enum Gander:short
{
   Male=1,
   Female=3,
   Unknown=34
}
public enum Season
{
    Winter=1,
    Spring=2,
    Summer=3
}
