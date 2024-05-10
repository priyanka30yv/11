using System;
namespace Weekend
{
class Upi{
protected String upid;
protected String pin;
public Upi(){}
public Upi(string a,string b)
{
upid=a;
pin=b;

}
public void display()
{
Console.WriteLine("UPI : {0}",upid);
Console.WriteLine("PIN : {0}",pin);
}
}

class Paytm:Upi
{
private bool audioSystem;
private string audioLanguage;
public Paytm(){}
public Paytm(string a,string b,bool c,string d): base(a,b)
{
upid=a;
pin=b;
audioSystem=c;
audioLanguage=d;

}
public void display()
{
 base.display();
Console.WriteLine("audio system :{0} ",audioSystem);
Console.WriteLine("audio system :{0} ",audioLanguage);

}
}
class Payments
{
public static void Main(string[] args)
{
Upi obj1=new Upi("5647@patym","39473");
obj1.display();
Console.WriteLine("****************************");
Paytm obj2=new Paytm("123@patym","142536",true,"marathi");
obj2.display();

}
}
}