using InheritancePartTwo;

/* 
 ***Casting and Reference Conversion***
 *An object reference can be:
    * Implicitly upcast to a base class reference
    * Explicitly downcast to a subclass reference
 *Upcasting and downcasting between compatible reference types performs reference
  conversions: a new reference is (logically) created that points to the same object. An
  upcast always succeeds; a downcast succeeds only if the object is suitably typed.
    
    **Upcasting**
    *An upcast operation creates a base class reference from a subclass reference:
 */


SubClass1 sc1 = new() { Name = "Mahammad", number = 17};
BaseClass bc = sc1;

Console.WriteLine(bc.GetHashCode());// 43942917
Console.WriteLine(sc1.GetHashCode());// 43942917
                                     //Their references are the same

/*
 *After the upcast, variable bc still references the same SubClass1 object as variable sc1.
 *The object being referenced is not itself altered or converted:
 */
Console.WriteLine(sc1==bc); //True
/*
    *Although bc and sc1 refer to the identical object, bc has a more restrictive view on
    that object:
*/
Console.WriteLine(sc1.Name);//Ok - Mahammad
Console.WriteLine(bc.Name);//Ok - Mahammad
Console.WriteLine(sc1.number);//Ok - 17
//Console.WriteLine(bc.number); //Compile-time Error

/*
 *The last line generates a compile-time error because the variable bc is of type BaseClass,
even though it refers to an object of type SubClass1. To get to its number field, you
must downcast the BaseClass to a SubClass1.

 */

/*
 **Downcasting**
    *A downcast operation creates a subclass reference from a base class reference:
 */
SubClass1 sc1_1 = new() { Name = "Nagi", number = 97};
BaseClass bc_1 = sc1_1; //Upcast
SubClass1 sc1_2 = (SubClass1) bc_1; //Downcasting
Console.WriteLine(sc1_2.number); //No error
Console.WriteLine(sc1_2 == bc_1);//True
Console.WriteLine(sc1_2 == sc1_1);//True
/*
    *As with an upcast, only references are affected—not the underlying object. 
    *A downcast requires an explicit cast because it can potentially fail at runtime:
House h = new House();
Asset a = h; // Upcast always succeeds
Stock s = (Stock)a; // Downcast fails: a is not a Stock

 */
SubClass1 sc1_3 = new();
BaseClass bc_2 = sc1_3; //Upcast always succeeds
//SubClass2 sc2 = (SubClass2)bc_2; // Downcast fails : bc_2 is not a SubClass2
//If a downcast fails, an InvalidCastException is thrown.




