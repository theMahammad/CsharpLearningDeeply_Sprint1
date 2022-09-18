using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    /* 
     ***Methods***
     */

}
internal class MethodHelper
    {
    
    /*
     **Local methods**
        * We can define a method within another method :
     */
    public void PrintSquares(int i)
    {

        Console.WriteLine(GetSquare(i));
        int GetSquare(int j)
        {
            return j * j;
        }

    }
    /*
     * Local method (GetSquare, in this case) is only visible to the enclosing method(PrintSquares).
     * This simplifies the containing type and instantly signals to anyone looking at the code that GetSquare is used nowhere else.
     * Another benefit of the local method is that they can access the local variables and parameters of the enclosing method 
     
     */


    /*
        **Static local methods**
            * Adding static modifier to a local method prevent it from seeing the local variables and parameters of the enclosing method.
            * This helps to reduce coupling and prevent the local method from accidentally referring to a variable used in the containing method.
            * 
     */
    public void PrintCube(int i)
    {
        

        int GetCube()
        {   
            return i * i * i; // There is no problem, nonstatic local method can access the variable in enclosing method;
        }
       /* static int GetCube2()
        {
            return i*i*i; //But in this code, we get a compile-time error. So, we can't access this variable from static method
        }
        */
    }

    /*
        **Overloading methods**
            *Local method cannot be overloaded :
     */

        void OverloadingLocals()
    {
        int method()
        {
            return 0;
        }
       /* int method(int i) // This method's signature is different from the above version, but still we get a compile time error
        {
            return 0;
        }
        */
    }

    /*
        * A type/class can overload methods(define multiple methods with the same name) as long as their signatures are different.
        * For example, the following methods all can coexist in the same type :
     */
    void Foo() { }
    void Foo(int number) { }
    void Foo(int number,float fl) { }
    void Foo(float fl, int number) { }

    /*
        * However, the following pairs of methods cannot coexist in the same type, because the return type is not the part of a method's signature
     */
    
    int Method() { return 0; }
    // string Method() { return null; } // Compile-time error

    

}
