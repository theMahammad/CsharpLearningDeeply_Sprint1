using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class MethodHelper
    {
        /*
            ***Methods within type/class***
                *A method's signature must be unique within the type. A method's signature comprises its name and passed parameter types in order(but not the parameter names, nor the return type)
            */
        public int Test()
        {
            return 0;
        }
        /* public string Test() // Although the return type of this method is different from above method, their names and parameter types are the same(Both don't have parameter,which make their signatures same)
        {
            return null;
        } */
        public int Test(int number) //Yes,We have 2 methods named Test, but their signatures are different in terms of passed parameters
        {
            return number;
        }
        /*  public int Test(int number1) // This method is also unavailable. Yes, the name of the its passed parameter is different from above version, but that doesn't mean anything.
         *  //When we call this method, naming changes nothing. We just pass our parameter
          {
              return number1;
          } */

        /*
         **Expression-bodied methods**
            *A method that comprises a single expression, such as :
         */
        int method(int x) { return x * x; }
        /*
         *can be written more tersely as an expression-bodied method. A fat arrow replaces brackets and return keyword :
         */
        int method2(int x) => x * x;

        /*
         *Expression-bodied methods can also have a void return type :
         */
        public void method3() => Console.WriteLine("Salam olsun yaxşı dünyaya");

      
    }
}
