using System;
namespace Greysoft
{
class IfExample
{
public static void Main(string[] args)
{
int avgBalance=0;
string remarks;
Console.WriteLine("enter the average balance");
avgBalance=Convert.ToInt32(Console.ReadLine());
if(avgBalance>=1500)
remarks="Issue the card";
else
remarks="do not issue the card";
Console.WriteLine(remarks);
}
}
}