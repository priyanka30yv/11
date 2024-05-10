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
}

class Paytm:Upi
{
private bool audioSystem;
private string audioLanguage;
public Paytm(){}
public Paytm(string a,string b,bool c,string d)
{
upid=a;
pin=b;
audioSystem=c;
audioLanguage=d;

}
public void display()
{
Console.WriteLine($"the upi id is{upid} having audiosystem set to {audioSystem} with preferred language {audioLanguage} ");


}
}
class Payments
{
public static void Main(string[] args)
{
Paytm obj1=new Paytm("123@patym","142536",true,"marathi");
obj1.display();

}
}
}