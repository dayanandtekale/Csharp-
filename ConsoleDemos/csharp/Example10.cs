using System;
namespace csharp
{
public class Example10
{
public static void Main(String[] args)
{
product obj1;
product obj2;
obj1= new product();
obj2= new product();
obj1.productname="Laptop";
obj1.price=33000;
obj2.productname="Mobile";
obj2.price=7000;
int totalprice=obj1.price+obj2.price;
Console.WriteLine($"The total price of my {obj1.productname} and {obj2.productname} is {totalprice}");
}
}
class product
{
public string productname;
public int price;
}
}