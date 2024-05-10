using System;
namespace Greysoft
{
class DoWhile{
public static void Main(string[]args)
{
int[] arr1=new int[]{10,20,30,40,50,60,70,10,20,30};
int i=0;
int sum=0;
do{
Console.WriteLine(arr1[i]);
sum=sum+arr1[i];
i++;
}

while(i<10);
Console.WriteLine(sum);
}
}
}
