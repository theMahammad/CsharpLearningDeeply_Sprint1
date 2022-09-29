/*
    **The as operator**
    *The as operator performs a downcast that evaluates to null 
    (rather than throwing an exception) if the downcast fails:
 */

using InheritancePartThree;
SubClass1 sc1 = new();
BaseClass bc = sc1;
SubClass2 sc2 =  bc as SubClass2; // sc2 is null; not exception thrown
Console.WriteLine(sc2);


