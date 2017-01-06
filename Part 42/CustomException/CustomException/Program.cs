using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            throw new FileNotFoundException("User is also logged in-- no duplicate session allowed.");
        }
    }
    public class UserAlreadyLoggedInException: Exception
    {
        public UserAlreadyLoggedInException()
            : base()
        {

        }
        public UserAlreadyLoggedInException(string message)
            :base(message)
        {

        }
    }
}
