using Constructors;
//These init-only properties act like read-only properties, except that they can also be set via an object initializer:
Test test = new Test() { MyProperty=5};
//test.MyProperty=5; //compile-time error
Test test1 = new();



Console.WriteLine($"{test.Id} {test.Name}");