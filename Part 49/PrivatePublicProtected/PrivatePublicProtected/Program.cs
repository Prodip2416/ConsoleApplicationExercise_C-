using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivatePublicProtected
{
    //public class Customer
    //{
    //    private int _id;
    //    public int Id
    //    {
    //        get { return _id; }
    //        set { this._id = value; }
    //    }
    //}

    public class Customer
    {
        protected int Id;
    }

    public class CorporateCustomer : Customer
    {
        public void PrintId()
        {
            CorporateCustomer cc = new CorporateCustomer();
            cc.Id = 101;
            // id is access able ,,,,, 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        //    Customer C1 = new Customer();
        //    Console.WriteLine(C1._id);// this is red error because _id is protected.
        //    Console.WriteLine(C1.Id);// this is public and no error.
        }
    }
}
