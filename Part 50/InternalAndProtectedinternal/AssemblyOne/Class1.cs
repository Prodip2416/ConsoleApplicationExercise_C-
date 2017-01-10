using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyOne
{
    public class AssemblyOneClass1
    {
        protected internal int id =101;
    }

    public class AssemblyOneClass2
    {
        public void SamplrMethod()
        {
            AssemblyOneClass1 ac = new AssemblyOneClass1();
            Console.WriteLine(ac.id);
        }
    }
}
