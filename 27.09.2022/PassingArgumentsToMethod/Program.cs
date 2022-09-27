/*
   ** params modifier**
        if applied to the last parameter of a method(we can't declare any parameter after a parameter used with params), allows the
        method to accept any number of arguments of a particular type. The parameter type
        must be declared as an array, as shown in the following example:
 */

using System.Text;
using System.Xml.Linq;

int result = Total(1, 2, 3, 4, 7);
Console.WriteLine(result);
int Total(params int[] numbers)
{
    int sum = 0;
    foreach (var number in numbers)
    {
        sum += number;
    }
    return sum;
}

/*
    **Named Arguments**
    *Rather than identifying an argument by position, you can identify an argument by name.
    *Named arguments can occur in any order
 */

Console.WriteLine(GetFullName(name: "Mahammad", surname: "Sadigzade"));
Console.WriteLine(GetFullName(surname: "Sadigzade", name: "Mahammad"));
/*However, there is a restriction: positional arguments must come before named
arguments unless they are used in the correct position. So, you could call the method like
this:
*/
GetFullName(name: "Mahammad", "Sadigzada"); // OK. Arguments in the declared positions
//But not like this:
//GetFullName(surname: "Sadigzada", "Mahammad"); // Compile-time error. y isn't in the first position

string GetFullName(string name, string surname)
{
    string fullname = $"{name} {surname}";
    return fullname;
}

/*
 **Ref locals**
 *A somewhat esoteric feature of C# is that you can define a local variable that refer
  ences an element in an array or field in an object (from C# 7):
 */
int[] numbers = { 1, 2, 3, 4, 5 };
ref int refToFirst = ref numbers[0];
/*
 * In this example, refToFirst is a reference to numbers[0]. When we modify refToFirst, we
modify the array element:
*/
Console.WriteLine(numbers[0]);//1
refToFirst += 15;
Console.WriteLine(numbers[0]);//16
/*
 **Target-typed expressions**
    *Another way to reduce lexical repetition is with target-typed new expressions:
 */
StringBuilder strBuild = new();
StringBuilder strBuild1 = new("salam");
//This is precisely equivalent to:
StringBuilder strBuild2 = new StringBuilder();
StringBuilder strBuild3 = new StringBuilder("salam");




