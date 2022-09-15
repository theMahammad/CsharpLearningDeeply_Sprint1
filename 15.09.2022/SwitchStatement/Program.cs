namespace SwitchStatement
{
    internal class Program
    {
        /*
            **Switching on types**

            *We can also switch on types :
            */
        static void PrintTheType(object o)//Due to being upper class/type of every type, we set "object" type for passed "o" parameter
        {
            switch (o)
            {
                case int i : //On this line, "i" equals the passed "o" parameter's value. We can also use other names for variable instead of it
                    Console.WriteLine("This value's type is integer");
                    Console.WriteLine($"Square of the value : {i*i}");
                    break;
                case string s:
                    Console.WriteLine("This value's type is string");
                    Console.WriteLine($"Length : {s.Length}");
                    break;
                default :
                    Console.WriteLine("The type of the variable is different from string and integer");
                    break; 
            }
           
        }
        

        
        static void Main(string[] args)
        {
            PrintTheType(5); // "This value's type is integer" 


        }
    }
}