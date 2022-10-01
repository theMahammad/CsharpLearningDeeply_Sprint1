using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Azerbaijan:World
    {
    //A subclass overrides a virtual method by applying the override modifier:
        public override void SayHello() => Console.WriteLine("Salam olsun");
        /*
         * By default, the method SayHello() prints "Hello World".
         * A subclass doesn't  always need to specialize its base class members, but whenever necessary, it can like above.
        */
        public int a;
    }

    
}
