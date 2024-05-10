using System;
namespace Greysoft
{
class Upi
{
public string Upid;
public int Pin;
public int TransactionLimit;
public int NumberOfTransactionPerDay;
public string status;
}
class MakePayments
{
public static void Main(string[]args)
{
Upi obj=new Upi();
obj.Upid="1234568@upi";
obj.Pin=12343;
obj.TransactionLimit=200000;
obj.NumberOfTransactionPerDay=10;
obj.status="Active";
Console.WriteLine("the Upi is {0} having transaction limit {1} and number of transaction per day {2} is {3}",obj.Upid,obj.TransactionLimit,obj.NumberOfTransactionPerDay,obj.status);

}
}
}