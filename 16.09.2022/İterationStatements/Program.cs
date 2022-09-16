namespace İterationStatements
{
    internal class Program
    {
        /* 
          ***Iteration Statements**
         
         */
        /*
         **While loops**
         
        *While loops repeatedly execute a body of code while a bool expression is true. The expression is tested before the loop body is executed. For example :
         */
       static void IncreaseToTen()
        {
            int i = 0;
            while(i < 10)
            {
                i++;
                Console.WriteLine(i);//After that codeline, new value of i is compared with 10 again. When,finally, i equals 10, the loop is ended
            }
        }
        /*
            **Do-while loops**
            
            *There are no big differences between while and do-while loops. But only one is that, the code block is executed first, then bool expression is checked
            *It means that regardless of the bool expression, code block is executed at least once. For example :
         */
        static void IncreaseToFive() 
        { int number = 5;
            do
            {
                Console.WriteLine("Bool expression can't block my executing :)))");//After first executing, the loop will be ended due to being false of the expression
            } while (number < 5);
        }

        /*
         **For loops**
         
         *For loops is similar to while loops with special clauses for initialization and iteration of a loop variable. A for loop contains three clauses as follows :
         * for( initialization-clause; condition-clause ; iteration-clause; )
                {
                statement block
                 }
         * Let's see the work of each clause :
            * Initialization clause
                *Executed before the loop begins; used to initialize one or more iteration variables
             *Condition clause
                *The bool expression that,while is true,will execute the body.
             *Iteration clause
                *Executed after  each iteration of the statement block; used typically to update the iteration variable
              
         */
        static void TestFor()
        {   
            for(int i=0; i<2; i++)
            {
                Console.WriteLine(i);
            }
            /* Let's list all steps :
             1. Initalizing a iteration variable(int i=0;)
             2. Checking the expression(i<2)-Now i equals 0, so the expression is true
             3. Executing the statement block - Print to console the value of the i which equals 0
             4. Increasing the value of the variable i by 1, which will equal 1.
             5. Checking the expression , which is true again 
             6. Executing the statement block
             7. Increase by one
             8. Checking the expression- Now the expression is false, because the value of the i equal to 2.
             9. Ending the loop
             */
           
        }
        /*
         **Foreach** 
         *There is another loop statement too, but using foreach is meaningful with arrays,lists. Now is not the time.
         */
        static void Main(string[] args)
        {
            IncreaseToTen();
            IncreaseToFive();
            TestFor();
        }
    }
}