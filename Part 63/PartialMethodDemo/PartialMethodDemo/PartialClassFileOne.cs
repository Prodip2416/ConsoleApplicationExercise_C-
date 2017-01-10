using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialMethodDemo
{
    public partial class SamplePartialClass
    {
        partial void SamplePartialMethod();
        partial void SamplePartialMethod()
        {
            Console.WriteLine("SamplePartialMethod invoked.");
        }
        public void PublicMethod()
        {
            Console.WriteLine("PublicMethod Invoked.");

            SamplePartialMethod();
        }
    }
}
