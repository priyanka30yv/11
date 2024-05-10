using System;
namespace Weekened
{
class Email
{
private string from;
private string to;
private string message;

internal void AcceptFromData(string from)
{ 
this.from=from;
}
internal void AcceptToData(string to)
{ 
this.to=to;
}
internal void AcceptMessageData(string message)
{ 
this.message=message;
}
internal String DisplayFromData()
{
return from;
}
internal String DisplayToData()
{
return to;
}
internal String DisplayMessageData()
{
return message;
}
}
public class Communication
{
public static void Main(string[] args)
{
Email obj1=new Email();
obj1.AcceptFromData("priyanka");
obj1.AcceptToData("priti");
obj1.AcceptMessageData("how are you!!!");
Console.WriteLine(obj1.DisplayFromData());
Console.WriteLine(obj1.DisplayToData());
Console.WriteLine(obj1.DisplayMessageData());

}
}
}
