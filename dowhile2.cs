using System;
namespace Greysoft
{
class DoWhile{
public static void Main(string[]args)
{
int[] arr1=new int[10];
int i=0;
int sum=0;
do{
Console.WriteLine("enter the element 10 elemets"+arr1[i]);
arr1[i]=Convert.ToInt32(Console.ReadLine());
sum=sum+arr1[i];
i++;
}
while(i<arr1.length);
Console.WriteLine(sum);
}
}
}