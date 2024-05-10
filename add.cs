using System;
namespace Dynasty
{
class Data {
public string source;
public void Add(int a,int b)
{
int ans=a+b;
Console.WriteLine("the addition of {0} and {1} is {2}",a,b,ans);
}
public static void Main(string[] args)
{
Data d=new Data();
d.source="me";
int x,y;
Console.WriteLine("enter the value of x");
x=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the value of y");
y=Convert.ToInt32(Console.ReadLine());
d.Add(x,y);
}
}
}
