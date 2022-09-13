//C# basics 
int x = 15 * 30; // Statement 1
System.Console.WriteLine(x); // Statement 2
/*
 Our program consists of two statements. Statements in C# execute sequentially and are ended by a semicolon.
 The first statement calculate the expression "15 * 30" and stores the result in a variable, named x, whose type is a 32-bit integer (int).
 The second statement calls WriteLine method on a class Called "Console", which is defined in a namespace called System. This prints the variable x to a text window on the screen
 Actually, On this program, we don't need to write "System", because it is used by default

 A method performs a function; a class groups functions and data members to form an object-oriented building block.
 At the outermost level, types are organized into namespaces. Many commonly used types—including the Console class—reside in the System namespace
 Qualifying the Console class with the System namespace on every use adds clutter.The "using" directive lets you avoid this clutter by importing a namespace:
 using System; (This should be used at the top of the code page)
 int x = 15 * 30; 
 Console.WriteLine(x); // No need to specify System.

A basic form of code reuse is to write higher-level functions that call lower-level
functions. We can refactor our program with a reusable method called FeetToInches
that multiplies an integer by 12, as follows:
 */
Console.WriteLine(MeterToCm(30)); // 3000
Console.WriteLine(MeterToCm(100)); // 1000
int MeterToCm(int meter)
{
    int cm = meter * 100;
    return cm;
}
/*
 Our method contains a series of statements surrounded by a pair of braces. This is called a statement block.

A method can receive input data from the caller by specifying parameters and output data back to the caller to specifying a return type.
Our MeterToCm method has a parameter for inputting meter and a return type for outputting cm

If any method doesn't receive input, use empty parentheses, and if it doesn't return anything, use "void" keyword
 */
void SayHello()
{
    Console.WriteLine("I'm executed from the void function");
}