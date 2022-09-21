namespace ValueVsReferenceTypes
{
    internal class Program
    {

        /*
            ***Value types vs Reference Types***
         */
        /*
         *Value types comprise most built-in types (specifically, all numeric types, the chartype, and the bool type) as well as custom struct and enum types.
         *Reference types comprise all class, array, delegate, and interface types. (This includesthe predefined string type.)
         *The fundamental difference between value types and reference types is how they are handled in memory
         */

        /*
            **Value types**
                *The content of a value-type variable is simply a value
                *We can define a custom value type with the struct keyword
         */
        public struct MyType{ public int X, Y; }

        /*
            *The assignment of a value type instance always copies the instance :
         */

        /* Example usages For Value-types
            static void Main(string[] args)
        {
            MyType myType = new MyType();
            myType.X = 5;
            MyType myType2 = myType; // myType2 copies the instance now;
            Console.WriteLine(myType.X); //5
            Console.WriteLine(myType.X); //5
            myType.X = 7;
            Console.WriteLine(myType.X);//7
            Console.WriteLine(myType2.X);//5 
            
             //This is due to the fact that, both instance have its independent storage  
             

    }
         */

        /*
                **Reference types**
         */

        /*
            *A reference type is more complex than a value type, having two parts : an object and the reference to that object
            *The content of a reference-type variable is a reference to an object that contains the value 
            *Assigning a reference-type variable copies the reference, not the object instance.
            *This allows multiple variable to refer to the same object , which is not available for value types.
         */

        public class MyClass{public int X, Y; }  //Class is a reference type
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.X = 9;
            MyClass myClass2 = myClass; // Copying the refence of the myClass variable
            Console.WriteLine(myClass.X);//9
            Console.WriteLine(myClass2.X);// 9

            myClass.X = 17;
            Console.WriteLine(myClass.X);//17
            Console.WriteLine(myClass2.X);//17
            //myClass and myClass2 are two variables that point to the same object
            //Let's named each section :
                //MyClass myClass  - Reference
                //new MyClass() - Object
            //So if we equal myClass2 to the myClass,actually,we make their reference same.
            
            
        }
    }
}