namespace PassingArgumentsToMethod
{
    internal class Program
    {
        /*
            ***Passing Arguments To Methods***
         */
        /*
            **The ref modifier**
            *To pass arguments by reference, C# provides the ref parameter modifier. 
            *In the following example, p and x refer to same memory locations :
            
         */

        static void Foo(ref int p)
        {
            p++;
            Console.WriteLine(p);
        }
       /* *Example usage of the  ref modifier
        static void Main(string[] args)
        {

            int x = 5;
            Foo(ref x); // p's value has  been printed which is 6 
            Console.WriteLine(x); //x has been passed with its reference, so each change in p affect on x too. Therefore, x  is also 6
           //A parameter can be passed by reference or by value, regardless of whether the parameter type is a reference type or a value type
             

        }
       */

        /*
            **The out modifier**
                *The out modifier is similar with the ref modifier except for the following :
                    *It need not to be assigned before passed to method
                    *It must be assigned before it comes out of function
                *The out modifier is mostly used to get multiple return values back from a method :    
         */ 
        static void Split(string fullName, out string firstName,out string lastName)
        {
            int index = fullName.LastIndexOf(' ');
            firstName = fullName.Substring(0, index);   
            lastName = fullName.Substring(index + 1);   


        }
        static void Main(string[] args)
        {
            string firstName,lastName;
            
            string fullName = "Mahammad Ali";
            Split(fullName, out firstName, out lastName);
            Console.WriteLine($"First name : {firstName}\nLast name : {lastName}");
            //Like a ref parameter,an out parameter is also passed by reference

        }
    }
}