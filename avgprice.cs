using System;
namespace Greysoft
{
class Product
{
internal int productid;
internal string productname;
internal float price;

}
class AvgPrice{

public static void Main(string[] args)
{
Product obj1=new Product();
Product obj2=new Product();
obj1.productid=1;
obj1.productname="laptop";
obj1.price=250000.50f;
obj2.productid=2;
obj2.productname="tv";
obj2.price=30000.0f;
float avgprice;
avgprice=(obj1.price+obj2.price)/2;
Console.WriteLine("the average price of {0} and {1} is {2}",obj1.productname,obj2.productname,avgprice);
}
}
}



