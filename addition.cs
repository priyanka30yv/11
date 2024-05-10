using System;
namespace Dynasty
{
class Addition{
public void Add(int a,int b)
{
Console.WriteLine("adding numbers . answer is {0}",(a+b));
}
public void Add(string a,string b)
{
Console.WriteLine("hello {0}. {1}",a,b);
}
public void Add(float x)
{
float ans=x*2.0f;

Console.WriteLine("a floatings . answer is {0}",ans);
}
}
class PloyExample
{
public static void Main(string[]args)
{
Addition obj=new Addition();
obj.Add(8,5);
obj.Add("priyanka","how are you!!!!!!");
obj.Add(10.6f);
}
}
}