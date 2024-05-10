using System;
namespace Greysoft
{
class MobileApp{
public string AppName;
public int Price;
public int AppSizeInMB;
public String AvailableOnPlayStore;
}
class Phone{
public static void Main(string[] args)
{
MobileApp obj1=new MobileApp();
obj1.AppName="whatsapp";
obj1.Price=120000;
obj1.AppSizeInMB=12;
obj1.AvailableOnPlayStore="yes";
double Space;
Console.WriteLine("enter the memory space which is available in your memory");
Space=Convert.ToInt32(Console.ReadLine());
if(Space>obj1.AppSizeInMB)
{
Console.WriteLine("install");
}
else

Console.WriteLine("please free the space it require more memory to install this app");

}
}

}