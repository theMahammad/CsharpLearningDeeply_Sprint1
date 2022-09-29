using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePartTwo
{
    
            

    internal class BaseClass
    {
        public string Name { get; set;  }
        public void Show()
        {
            Console.WriteLine($"{this.GetType()} I'm a base class"); //Thanks to this.GetType(), we can find the name of the  derived class  using this method
        }

        



    }
}
