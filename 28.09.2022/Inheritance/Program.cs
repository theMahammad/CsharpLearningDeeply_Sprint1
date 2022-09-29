using Inheritance;
//Here’s how we can use inheritance phenomenon:
SubClass1 subClass1 = new();
subClass1.Name = "Mahammad"; // 
subClass1.number = 5;
subClass1.Show();// Inheritance.SubClass1 I'm a base class

//Above instance can access BaseClass members beside its own members.

SubClass2 subClass2 = new();
subClass2.condition = false;
subClass2.Name = "Nagi";
subClass2.Show();//Inheritance.SubClass2 I'm a base class
//The derived classes, SubClass1 and SubClass2, inherit the Name property and the Show method from the base class, BaseClass.
//A base class is also called a superclass.

/*
         **Polymorphism**
            *References are polymorphic. This means a variable of type x can refer to an object
             that subclasses x. For instance, consider the following method:

         */
//This method can show both a SubClass1 and a SubClass2 because they are both BaseClass:
void Display(BaseClass instance)
{
    Console.WriteLine(instance.Name);
}
Display(subClass1); // I Mahammad
Display(subClass2);//  Nagi

/*
 *Polymorphism works on the basis that subclasses (SubClass1 and SubClass2) have all the
features of their base class (BaseClass). The converse, however, is not true. If Display
was modified to accept a SubClass1, you could not pass in an BaseClass:
 
 */
void Display2(SubClass1 instance){
    Console.WriteLine(instance.Name);
}

Display2(subClass1); // Mahammad
//Display2(subClass2); // Compile-time error. SubClass2 and SubClass1 are on the same level. None of the is base.
BaseClass baseClass = new();
//Display2(baseClass);// Compile-time error. While SubClass1 can access the members of the BaseClass, BaseClass can't.

