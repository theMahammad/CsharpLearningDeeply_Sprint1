using System.Runtime.CompilerServices;

namespace Methods
{
    internal class Program
    {
        static void Method(ref int number)
        {
            number++;
            Console.WriteLine(number);

        }
        static void Main(string[] args)
        {
            int number = 7;
            Method(ref number);
            Console.WriteLine(number);
        }
    }
}