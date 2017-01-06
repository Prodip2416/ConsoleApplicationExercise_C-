using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @struct
{
    public class Customer
    {
        //private Fields...........
        private int _id;
        private string _name;


        //Properties for _id
        public int ID
        {
            get { return this._id; }
            set { this._id = value; }
        }

        //Properties for _name
        public string Name
        {
            get {return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// Constructor
        /// </summary>
        public Customer(int Id,string Name)
        {
            this._id = Id;
            this._name = Name;
        }
        //Method .......
        public void PrintDetails()
        {
            Console.WriteLine("Id = {0} and Name = {1}", this._id, this._name);
            Console.ReadLine();
        }
    }
    class Program
    {
       public static void Main(string[] args)
        {
            Customer C1 = new Customer(101, "Mark");
            C1.PrintDetails();

        }
    }
}
