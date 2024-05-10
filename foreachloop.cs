using System;
namespace Greysoft
{
class ForEachLoop
{
public static void Main(string[]args)
{
string[] apps=new string[5];
apps[0]="whatsapp";
apps[1]="instagram";
apps[2]="uts";
apps[3]="yatri";
apps[4]="uber";
foreach(string i in apps)
{
Console.WriteLine(i);
}
}
}
}