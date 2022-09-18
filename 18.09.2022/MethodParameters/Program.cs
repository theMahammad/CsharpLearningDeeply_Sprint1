namespace MethodParameters
{
    internal class Program
    {

        /*
            ***Method parameters***
         */

        /*
             * A method may have a sequence of parameters. Parameters define the set of arguments that must be provided for using that method.
             * In the following example, the method Foo has a single parameter named p, of type int :
         */
        static void Foo(int p) { } //p is a parameter
        // Foo(5); // 5 is an argument
        /*
            * We can control how parameters are passed with ref,in and out modifiers.
         */
        /*
            **Passing arguments by value**
                * By default, arguments in C# are passed by value, which is by far the most common case.
                * This means that a copy of the value is created when passed to the method
         */
        public static void IncreaseAndPrint(int number){

            number++;
            Console.WriteLine(number);
        }
        static void Main(string[] args)
        {
            int number = 5;
            IncreaseAndPrint(number); //6 -- The variable named number's value's copy has been created 
            Console.WriteLine(number);// 5 -- Due to increasing value's copy, original variable has not been affected
        }
        



    }
}