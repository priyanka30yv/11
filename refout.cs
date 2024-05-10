using System;
namespace Weekend
{

class refout
{
public static void Main(string[] args)
{
int x=Convert.ToInt32(args[0]);
int y=Convert.ToInt32(args[1]);
Console.WriteLine("original value X={0},Y={1}",x,y);
swap(ref x,ref y);
Console.WriteLine("final  value X={0},Y={1}",x,y);
}
static void swap(ref int a,ref int b)
{
Console.WriteLine("original value A={0},B={1}",a,b);
int temp=a;
a=b;
b=temp;

Console.WriteLine("final value A={0},B={1}",a,b);
}
}
}