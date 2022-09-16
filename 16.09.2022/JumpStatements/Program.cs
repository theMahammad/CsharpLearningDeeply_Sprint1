namespace JumpStatements
{
    internal class Program
    {
        /*
         ***Jump statements***
         *The C# has five jump statements, which are break,continue, goto, return and throw
         */
        /*
         **Break statement**
         
         *The break statement ends the execution of the body of an iteration or switch statement :
         */
        static void TestBreak()
        {
            while (2 == 2)//That's not a recommendable bool expression, it result in an infinity loop if we don't use "break" statement
            {
                Console.WriteLine("Test 1");
                break; //After printing the text, the iteration is ended. So following codeline won't be executed.
                Console.WriteLine("Test 2");
            }
            Console.WriteLine("Test 3");//Due to the ending of the just iteration, this codeline will be executed.
        }

        /*
         **Continue statement**
         
         *continue statement forgoes remaining statements in a loop and skip to the next iteration. Let's  make a loop which its statements execute only for odd numbers: 
         */

        static void PrintOddNumbers()
        {
            for(int i = 0; i < 10; i++)
            {
                if (i % 2 == 0) //When the value of the i is even, the code skips to next iteration, which means that these numbers won't be printed
                {
                    continue;
                }
                Console.WriteLine(i);
            } 
        }
       
        static void Main(string[] args)
        {
            TestBreak(); 
            PrintOddNumbers();
            
        }
    }
}