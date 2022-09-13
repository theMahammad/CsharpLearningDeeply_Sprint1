namespace StringType
{
    
    internal class Program
    {/*
       ***Strings and Characters***
      */

        /*
         **Char type**
         * C#'s char type represents a Unicode character and occupies 2 bytes in memory. A char literal is specified within single quotes :
         */
        public static char ch = '5';

        /*
         **String type**
         *C#'s string type represents an immutable(unchangeable) sequence of Unicode characters. A string literal is specified within double quotes
         */
        string str = "example";
        /*
         Escape sequences express characters that cannot be expressed or interpreted literally.
         An escape sequence is a backslash followed by a character with a special meaning;
         for example : 
        char newLine = '\n';
        char backSlash = '\\';

        The escape sequences that are valid for char literals also work inside strings. The cost of this is that whenever you need a literal backslash, you must write it twice:

            string path = "\\\\server\\fileshare\\helloworld.cs";


        To prevent this problem, C# allows verbatim string literals. A verbatim string literal
        is prefixed with @ and does not support escape sequences. The following verbatim
        string is identical to the preceding one:

            string a2 = @"\\server\fileshare\helloworld.cs";

        You can include the double-quote character in a verbatim literal by writing it twice:
           
         */
        string doubleQuote = @"""Salam""";

        /*
            **String interpolation**
            *A string preceded with the $ character is called an interpolated string. Interpolated strings can include expressions enclosed in braces:
         */
        static int ex = 57;
        string usingEx = $"PRice : {Program.ex}";
        
        static void Main(string[] args)
        {


            
    }
    }
}