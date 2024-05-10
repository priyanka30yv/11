using System;
namespace Dynasty
{
class CurrencyCoversion {
internal string From;
internal string To;
internal float Amount;
internal float CRate;
internal void Acceptance(){
Console.WriteLine("currency to");
To=Console.ReadLine();
Console.WriteLine("currency from");
From=Console.ReadLine();
Console.WriteLine("Amount");
Amount=Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Conversion rate");
CRate=Convert.ToSingle(Console.ReadLine());

}
public float CalcFinalAmount(){
float ans=Amount*CRate;
return ans;
}}
class Finance{
public static void Main(string[]args)
{
CurrencyCoversion obj =new CurrencyCoversion();
obj.Acceptance();
float finalamt=obj.CalcFinalAmount();
Console.WriteLine("the conversion of amount {0} from currency {1} to {2} is{3}",obj.Amount,obj.From,obj.To,finalamt);
}
}
}