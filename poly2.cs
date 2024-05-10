using System;
namespace Weekend
{
class Greeting
{

public  virtual void display()
{
Console.WriteLine("Good Afternoon");
}
}
class IndependentDay:Greeting
{
public override void display()
{
Console.WriteLine("happy independence day");
}
}
class NewYear:Greeting
{
public override void display()
{
Console.WriteLine("happy new year ");
}
}
class Poly2{
public static void Main(string[] args)
{
Greeting obj;
int choice;
Console.WriteLine("enter 1 for independence day and 2 for new year");
choice=Convert.ToInt32(Console.ReadLine());
switch(choice){
case 1:
obj=new IndependentDay();
break;
case 2:
obj =new NewYear();
break;
default:
obj=new Greeting();
break;
}
obj.display();

}
}
}
