using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideEqualMethods
{
    class Program
    {
       public static void Main(string[] args)
        {
            #region 3rd nad 4th  Example
            
            Customer C1 = new Customer();
            C1.FirstName = "Prodip";
            C1.LastName = "SarKer";

           Customer C2 = new Customer();
            C2.FirstName = "Tuhin";
            C2.LastName = "Al Jobaed";

            Console.WriteLine(C1 == C2);
            Console.WriteLine(C1.Equals(C2));
           
            #endregion

            #region'2nd Example
            /*
            Direction D1 = Direction.East;
            Direction D2 = Direction.East;

            Console.WriteLine(D1 == D2);
            Console.WriteLine(D1.Equals(D2));
            */
            #endregion

            #region 1st Example
            //int i = 10;
            //int j = 10;

            //Console.WriteLine(i == j);
            //Console.WriteLine(i.Equals(j));
            #endregion


            Console.ReadLine();
        }
        public class Customer
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public override bool Equals(object obj)
            {
                // If the passed in object is null
                if (obj == null)
                {
                    return false;
                }
                if (!(obj is Customer))
                {
                    return false;
                }
                return (this.FirstName == ((Customer)obj).FirstName)
                    && (this.LastName == ((Customer)obj).LastName);
            }
            public override int GetHashCode()
            {
                return FirstName.GetHashCode() ^ LastName.GetHashCode();
            }
        }
        #region 2nd Example
        //public enum Direction
        //{
        //    East = 1,
        //    West = 2,
        //    North = 3,
        //    South = 4
        //}
        #endregion
    }
}
