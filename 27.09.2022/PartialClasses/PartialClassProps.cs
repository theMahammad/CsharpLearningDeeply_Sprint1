using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses
{
    /*
        **Partial class**
        *In C#, you can split the implementation of a class, a struct, a method, or an interface in multiple .cs files using the partial keyword.
        *The compiler will combine all the implementation from multiple .cs files when the program is compiled.
     */
    internal  partial class PartialClass
    { //Nested Partial types
        public partial class Ala {

            public string name;
        }
        public partial class Ala
        {
            public string surname;
        }
        void SetValuesToAla()
        {
            Ala ala = new();
            ala.name = "Mahammad";
            ala.surname = "Sadiqzade";
        }
       
        public int Id { get; set; }

    }

    /*
        **Rules for Partial Classes**
        *All the partial class definitions must be in the same assembly and namespace.
        *All the parts must have the same accessibility like public or private, etc.
        *If any part is declared abstract, sealed or base type then the whole class is declared of the same type.
        *The Partial modifier can only appear immediately before the keywords class, struct, or interface.
        *Nested partial types are allowed.
     */
}
