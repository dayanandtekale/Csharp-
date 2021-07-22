using System;
namespace csharp
{
public class Example2
{
public static void Main(String[] args)
{
int price=1200;
string productname="Keyboard";
float discount=0.2f;
float finalamount=price -(price*discount);
Console.WriteLine("The price of the {0} is {1} and after discount of {2} the final price is {3}", productname, price, discount, finalamount);
}
}
}