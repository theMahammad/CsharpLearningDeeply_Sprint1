using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /*
            **Inheritance**
            *A class can inherit from another class to extend or customize the original class.
            Inheriting from a class lets you reuse the functionality in that class instead of building it from scratch. 
            A class can inherit from only a single class but can itself be
            inherited by many classes, thus forming a class hierarchy. In this example, we begin
            by defining a class called BaseClass:

         */
    /* Next, we define classes called SubClass1 and SubClass2, which will inherit from Asset.
        Stock and House get everything an Asset has, plus any additional members that they define:
    */

    internal class BaseClass
    {
        public string Name { get; set;  }
        public void Show()
        {
            Console.WriteLine($"{this.GetType()} I'm a base class"); //Thanks to this.GetType(), we can find the name of the  derived class  using this method
        }

        



    }
}
