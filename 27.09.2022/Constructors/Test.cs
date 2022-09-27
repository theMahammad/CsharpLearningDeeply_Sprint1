using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Test
    {
        public int Id { get; set; }
        public static string Salam;
        public string Name { get;  }
        
        public Test():this("Mahammad") 
        {
            this.Id = 1;
            
            //By default : id=0, name = null
        }
        private Test(string name)//We set this constuctor private, so nobody can set a value for Name property
        {
            this.Name = name;
        }
        
        /*
            **init-only setters**
            *From C# 9, you can declare a property accessor with init instead of set:
         */
        public int MyProperty { get; init; }

        /*
            **Static constructor**
             *A static constructor executes once per type rather than once per instance. A type can
             define only one static constructor, and it must be parameterless and have the same
             name as the type:

         */

        static Test()
        {
            Console.WriteLine("I'm executing once");
        }
        /*
         * The runtime automatically invokes a static constructor just prior to the type being used. Two things trigger this:
            * Instantiating the type
            * Accessing a static member in the type
         */


    }
}
