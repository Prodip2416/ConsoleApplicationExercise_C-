using System;
using AssemblyOne;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyTwo
{
    public class AssemblyTwoClass
    {
        public void Text()
        {
            AssemblyOneClass A1 = new AssemblyOneClass();
            A1.Print();
        }
    }
}
