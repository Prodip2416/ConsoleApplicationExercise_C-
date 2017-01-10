using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesVsTypesMember
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Customer
    {
        /*
         in this example...
         Customer are Type.
         and
         Fields,Properties,Method are type Members.....
         */

        #region Fields
        private int _id;
        private string _FirstName;
        private string _LastName;
        #endregion

        #region Properties
        public int Id
        {
            get { return _id; }
            set { this._id = value; }
        }
        public string FirstName
        {
            get { return _FirstName; }
            set { this._FirstName = value; }
        }
        public string LastName
        {
            get { return _LastName; }
            set { this._LastName = value; }
        }
        #endregion

        #region Method
        public string getFullName()
        {
            return this._FirstName + " " + this._LastName;
        }
        #endregion
    }
}
