namespace JumpStatements
{
    internal class Program
    {
        /* 
         ***Jump Statements(Follow-up)***
         */

        /*
         **Return statement**
            *The return statement completely exits method and must return an expression whose type is the same with nonvoid method's type:
         */
        static int TestReturn(){
            int i = 0;
            while (true)
            {
                i++;
                if (i == 7)
                {
                    return i;//When i equals to 7,this command will be executed and the work of the method will be ended
                }
            }
        }
        /*
            **Return vs break**
                *Obviously, they are different. In the simplest term, their syntax are different. While the break is used alone, the return need to a value after itself
                *But there is a similar point between these statements that both statements exits from a loop. 
                *But while break statements doesn't interlope the executing of method after loop block, return statements completely ends the work of the method.
         */
        static int TestBreakWithReturn() {
            int i = 0;
            while (true)
            {
                i++;
                if (i == 5)
                {
                    break; //This statement breaks the loop, but method continues executing.
                }
            }
            Console.WriteLine("i is coming");

            while (true)
            {
                i++;
                if (i == 8)
                {
                    return i;//This statement breaks all method and return i's value.
                }
            }
            Console.WriteLine("I has come");//Due to using after return statement, this code line isn't read from the compiler.
            
        
        }
        static void Main(string[] args)
        {
            Console.WriteLine(TestReturn()); //TestReturn() is a nonvoid function, it means that it must return a value. It returns 7 and we print this value.
            Console.WriteLine(7);//It has same meaning with above code.
            Console.WriteLine(TestBreakWithReturn()); 
        }
    }
}