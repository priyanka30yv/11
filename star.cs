using System;
namespace Greysoft
{
class SwitchExample
{
public static void Main(string[]args)
{
int Count=0;
String remarks="";
Console.WriteLine("give the star");
Count=Convert.ToInt32(Console.ReadLine());
switch(Count)
{
case 5:
remarks="Excellent";
break;
case 4:
remarks="very good";
break;
case 3:
remarks="good";
break;
case 2:
remarks="average";
break;
case 1:
remarks="below average";
break;
default:
remarks="invalid choice";
break;
}
Console.WriteLine(remarks);
}
}
}
