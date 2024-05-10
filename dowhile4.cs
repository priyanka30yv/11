using System;
namespace Greysoft
{
class DoWhile4{
public static void Main(string[]args)
{
int a=0;
int[] arr=new int[10];

do{
Console.WriteLine("enter a 10 elements{0}",a+1);
arr[a]=Convert.ToInt32(Console.ReadLine());


a++;
}
while(a<arr.Length);
int sum=0;
a=0;
do{
sum=sum+arr[a];
a++;
}
while(a<arr.Length);
Console.WriteLine(sum);
}
}
}
