

using İnheritance;

/*
 **As operator**
 *The as operator performs a downcast that evaluates to null (rather than throwing
  an exception) if the downcast fails:
 */
Son son = new();
Father father = son;
Son son1 = father as Son; // son is null; no exception thrown
//This is useful when you’re going to subsequently test whether the result is null:
if (son == null)
{
    Console.WriteLine("salam");
}
/*
    *The as and cast operators will also perform upcasts, 
    although this is not terribly useful because an implicit conversion will do the job.

 */

/*
    **The is operator**
    *The is operator tests whether a variable matches a pattern. C# supports several kinds of patterns, the most important being a type pattern, 
    *where a type name follows the is keyword.
    *In this context, the is operator tests whether a reference conversion would succeed
    —in other words, whether an object derives from a specified class (or implements
    an interface). It is often used to test before downcasting:
 */
if(son1 is null)
{
    Console.WriteLine("salamlar");
}
/*
    **Introducing pattern variable**
 */
if(father is Son son2)
{
    son2.Name = "Maqa";
   
    Console.WriteLine(son2.Name);
}
//This is equivalent to the following:
if(father is Son)
{
    Son son3 = (Son)father; //son2 was handled in memory
}




