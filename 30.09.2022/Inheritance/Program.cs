using Inheritance;

World world = new();
Azerbaijan azerbaijan = new();
azerbaijan.a = 5; //the value of the variable a is declared
World world2 = azerbaijan; //Upcasting
//Console.WriteLine(world2.a); This line throws compile-time error due to cannot accesing 'a' variable
Azerbaijan azerbaijan1 = world2 as Azerbaijan; 
Console.WriteLine(azerbaijan1.a); //The value of this variable is the same,5. Its value remains,just cannot be accessed from the world variable 

//Overriding

world.SayHello(); // Hello World -- Its type is World and  keeps the reference of World object
azerbaijan.SayHello(); //Salam olsun -- Its type is Azerbaijan and keeps the reference of an Azerbaijan object
world2.SayHello(); // Salam olsun -- Its type is World, but it keeps the reference of an Azerbaijan object


