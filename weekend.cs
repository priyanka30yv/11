using System;
namespace Weekened
{
class Email
{
private string from;
private string to;
private string message;

internal void AcceptData(string a,string b,string c)
{ 
from=a;
to=b;
message=c;

}
internal void DisplayMessage()
{
Console.WriteLine("{0} send a message to {1} and the message is {2}",from,to,message);
}
}
public class Communication
{
public static void Main(string[] args)
{
Email obj1=new Email();
obj1.AcceptData("priyanka","priti","how are you");
obj1.DisplayMessage();


}
}
}
