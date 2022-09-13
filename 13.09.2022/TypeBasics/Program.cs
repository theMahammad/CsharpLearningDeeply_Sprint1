/*******************Type Basics************/

/*
 A type defines a blueprint for a variable.
 */
int x = 12 * 30;
Console.WriteLine(x);
// A variable points a storage location that can contain different values over time. In contrast, the constant always represents the same value
const int y = 5;
//All values in C# are instances of a type.The meaning of a value and the set of possible values a variable can have are determined by its type.

/*Predefined Types*/

/* Predefined types are types that are specially supported by the compiler.
 * The "int" type is a predefined type for representing the set of the integers that fit into 32 bits of memory.
 * 
 * Another predefined type is string. The string represents a sequence of characters, such as ".NET" or "ASP"
 *  You can work with strings by calling functions on them, like this:
 */
string name = "Mahammad";
Console.WriteLine(name.ToUpper()); //MAHAMMAD

/*Custom Types*/

/* Just as we can write our own method, we can also write our own types.
 * Now, we define a custom type named UnitConverter which is a class that serve as a blueprint for unit conversions
 
 */
public class UnitConverter
{
    int ratio; //Field

    public UnitConverter(int unitRatio) //Constructor
    {
        ratio = unitRatio;

    }
    public int Convert(int unit) //Method

    {
        return unit*ratio;
    }
}
/*
 Data is created by instantiating a type. Predefined types can be instantiated simply
by using a literal such as 12 or "Hello world". The new operator creates instances of
a custom type. We created and declared an instance of the UnitConverter type with
this statement:

    UnitConverter feetToInchesConverter = new UnitConverter (12);

Immediately after the new operator instantiates an object, the object’s constructor is
called to perform initialization. A constructor is defined like a method, except that
the method name and return type are reduced to the name of the enclosing type:

    public UnitConverter (int unitRatio) { ratio = unitRatio; }

 */

/*
 * The data members and function members that operate on the instance of the type
    are called instance members. The UnitConverter’s Convert method and the int’s
    ToString method are examples of instance members. By default, members are
    instance members.

    Data members and function members that don’t operate on the instance of the type
    can be marked as static. To refer to a static member from outside its type, you
    specify its type name rather than an instance. An example is the WriteLine method
    of the Console class. Because this is static, we call Console.WriteLine() and not
    new Console().WriteLine().

    In the following code, the instance field CitizenName belong to an instance of a particular
    Country, whereas Population belong to the set of all Country instances. We create two
    instances of the Country, print their names, and then print the total population:
    
     public class Country
    {
     public string CitizenName; // Instance field
     public static int Population; // Static field
     public Country (string n) // Constructor
     {
     CivilianName = n; // Assign the instance field
     Population = Population + 1; // Increment the static Population field
     }
    Country c1 = new Country ("Kung Fu Panda");
    Country c2 = new Country ("Fighter Panda");
    Console.WriteLine (c1.CitizenName); // Kung Fu Panda
    Console.WriteLine (c2.CitizenName); // Fighter Panda // Each instantiation called type's constructor method which increase population one by one
    Console.WriteLine (Country.Population); // 2
    

    Attempting to evaluate p1.Population or Panda.Name will generate a compile-time
    error.

 */