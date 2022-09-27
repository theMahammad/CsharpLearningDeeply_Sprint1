using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses
{
    internal partial class PartialClass
    {
        /*
         **Partial methods**
        *A partial class may contain a partial method. One part of the class contains the signature of the method. An optional implementation may be defined in the same part or another part. 
        *If the implementation is not supplied, then the method and all calls are removed at compile time.
         */
        public partial void SayHello();
        public partial void SayHello()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
