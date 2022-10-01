using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{ /*
    **Virtual Function Members**
    *A function marked as virtual can be overridden by subclasses wanting to provide a specialized implementation. Methods, properties, indexers, and events can all be declared virtual:

   */
    internal class World
    {
        
        public virtual void SayHello() => Console.WriteLine("Hello world"); //Expression-bodied method
        
    }
}
