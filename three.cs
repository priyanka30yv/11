using System;
namespace Greysoft
{
class Tax
{
public static void Main(string[]args)
{
int gross=0;
double tax=0;
Console.WriteLine("enter a amount");
gross=Convert.ToInt32(Console.ReadLine());

if(gross<=200000)
tax=0;
else
if(gross<=500000)
tax=0+(gross-200000)*0.05;
else
if( gross<=700000)
tax=0+300000*0.05+(gross-500000)*0.1;
else
if( gross<=120000)
tax=0+300000*0.05+200000*0.1+500000*.2+(gross-1200000)*.3;
else
if(gross>=1200000)
tax=0+300000*0.05+200000*0.10+(gross-700000)*0.20;  
Console.WriteLine(tax);
}
}
}



