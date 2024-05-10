using System;
namespace Weekened
{
class Email
{
private string from;
private string to;
private string message;

public Email()
{
from="priyanka";
to="priti";
message="how are you!!!!";
}
internal Email(string a,string b,string c)
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
Email obj1=new Email("priyanka","neelu","heyyyyy!!!!!!!!!!!!!");
Email obj2=new Email();
obj1.DisplayMessage();
obj2.DisplayMessage();


}
}
}
