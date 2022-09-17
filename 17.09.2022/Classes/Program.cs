using System.Reflection.Metadata.Ecma335;

namespace Classes
{
    internal class Program
    {
        /*
         ****Creating types in C#****
         */
        /*
         ***Classes***
            *A class is most common kind of reference type. The simplest possible class declaration is like this :
         */
        class MyClass
        {

        }
        /*
         ***Fields***
            *A field is a variable that is a member of a class or struct :
         */
       public class Person
        {
            string name;
            int age;
            /*
             **Field initialization**
                *Field initalization is optional. An uninitialized field has a default value(0--int,\0--char,null--reference types,false--bool)
             */
            string email = "salam@gmail.com";
            //Declaring multiple fields together(if they should have same type)
            string password = "123456", secretWord = "Oglanliq";

           
        }
        static void Main(string[] args)
        {

           
        }
    }
}