using System.Runtime.CompilerServices;

namespace IterationStatements
{
    internal class Program
    {
        /* 
         ***Iteration statements***
         
         * C# allows a sequence of statements to execute repeatedly with the while, do-while, for and foreach statements.
         
         */
        /*
            **While and do-while statements**
            
            *While loops repeatedly execute a body of code while the bool expression is true.
            *The expression is tested before and the body of the loopp is executed :
         */
        static void IncreaseToTen(int number)
        {
            while(number < 10)
            {
                Console.WriteLine(number);
                number++;
            }
        }
        
        static void Main(string[] args)
        {
            IncreaseToTen(5); // 5 6 7 8 9
        }
    }
}