using PartialClasses;


PartialClass partialClass = new();
partialClass.SayHello();

/*
    **The nameof operator**
    *The nameof operator returns the name of any symbol (type, member, variable, and so on) as a string:
 */
int count = 123;
string name = nameof(count);
Console.WriteLine(name);//count
