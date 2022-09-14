using System.Collections.Concurrent;

namespace Statements
{ /*
    ***Statements***
   */
    internal class Program
    {
        /*  
            *C# has following mechanisms to conditionally control the flow of the program execution:
                *Selection statements(if-else,switch)
                *Conditional operator(?:)
                *Loop statements(for,while,foreach)
         */

        
        static void Main(string[] args)
        {
            /*
             **If statement**
             
             *If statement executes a statement if a bool expression is true:
             */
            if (5 + 4 > 7)
                Console.WriteLine("Yeah");
            /*
              If and when we have a code with multiple lines, we must involve statements to a code block :
             */
            if (5 + 4 < 7)
                Console.WriteLine("This will not be printed");//This line depends on bool expression inside if statement
                Console.WriteLine("This will be printed");// This line is independent
            if (5 + 4 < 7) 
            {
                Console.WriteLine("This will not be printed");
                Console.WriteLine("This will not be printed too"); 
                /* Due to being written in a code block, both statement become dependent on bool expression */
            }



            /*
             **else clause**
             
            *An if statement can optionally feature an else clause. It is used to write some statements which go in the case that the bool expression in the if is false
             */
            if (false)
            {
                Console.WriteLine("This will not be printed");
            }
            else
            {
                Console.WriteLine("This will be printed");
            }
            /*
             But only "else" clause can't contain a condition that sometimes we need to use second condition. In such circumstances, we can use "else if" :
             */
            int age = 45;
            if (age >= 35)
            {
                Console.WriteLine("Why don't you be a president?");
            }else if (age >= 18)
            {
                Console.WriteLine("You can vote, but is a bit earlier to become a president :)");
            }
            else
            {
                Console.WriteLine("You are a baby now :) ");
            }
            /****************************************************************************************8*/
            /*
             **Switch statement**
             *
             * Switch statements allow you branch program execution based on a selection of a possible values that a variable might have :
             */
            char gpaLetter= 'A';
            switch (gpaLetter)
            {
                case 'A': Console.WriteLine("Your gpa is between 90-100"); //With switch statement, we comparise the value of the variable used inside switch's parantheses against the each values written after 'case' clause.
                    break;
                case 'B': Console.WriteLine("Your gpa is between 80-90");
                        break;
                default: 
                    Console.WriteLine("Your gpa is under from 80");
                    break;
            }
            /*
             * At the end of the each 'case' clause , you must specify explicitly where the execution is to go next, with some kind of jump statements.
             * Here are the options:
                • break (jumps to the end of the switch statement)
                • goto case x (jumps to another case clause)
                • goto default (jumps to the default clause)
                • Any other jump statement—namely, return, throw, continue, or goto label

             *When more than one value should execute the same code, we can list common common cases sequentially
             */

            char GPALetter = 'C';

            switch (GPALetter)
            {
                case 'A':
                case 'B':
                case 'C':
                    Console.WriteLine("You have won stipendium");//If GPALetter's value is one of the above values, this code will will be executed
                    break;
                default :
                    Console.WriteLine("Try one year after :) "); //But the value is different from these values, this statement will be executed.
                    break;
            }
            /*
             **Switching on types**
             
             *We can also switch on types :
             
             */
            switch (5)
            {
                case int a:
                    Console.WriteLine("It is an int type");
                    break;
                case string s: 
                    Console.WriteLine("It is an string type");
                    break;
            }


        }
    }
}