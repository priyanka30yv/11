using System;
namespace Dynasty
{
class Message
{
internal String From;
internal String To;
internal void Greet()
{
Console.WriteLine("{0} said byeeee {1}",From ,To);
}
internal void Indian()
{
Console.WriteLine(" {0} said namaste to {1}",From ,To);
}
internal void Spanish()
{
Console.WriteLine(" {0} said hola to {1}",From ,To);
}
internal void French()
{
Console.WriteLine("{0} said french to {1}",From,To);
}

}
class Whatsapp{
public static void Main(string[] args)
{
Message m=new Message();
Console.WriteLine("enter from");
m.From=Console.ReadLine();
Console.WriteLine("enter to");
m.To=Console.ReadLine();
m.Indian();
m.Spanish();
m.French();
m.Greet();
}
}
}
