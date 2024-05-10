using System;
namespace Dynasty
{
class Greeting
{
internal void Greet(string name)
{
Console.WriteLine("{0} is doing work",name);
}
internal void Greet(string msg,string name)
{
Console.WriteLine("{0} is doing work and {1} ",name,msg);
}
internal void Greet()
{
Console.WriteLine("no work");
}
}
class Work
{
public static void Main(string[] args)
{
Greeting obj1=new Greeting(); 
obj1.Greet("priyanka");
obj1.Greet


("priyanka","go");
obj1.Greet();
}}}