using System;
namespace csharp
{
public class Example5
{
public static void Main(String[] args)
{
String ans;
float discount;
Console.WriteLine("Do you want to print?");
ans= Console.ReadLine();
Console.WriteLine("Enter the discount percentage");
discount=System.Convert.ToSingle(Console.ReadLine());
Console.WriteLine("**********Syntax1*************");
if(ans=="Y" || ans=="y")
        Console.WriteLine("Printing. Please wait.........");
        Console.WriteLine("**************Syntax4********");
        if(discount>=0.2f)
        {
Console.WriteLine("Congrats....");
Console.WriteLine("You are eligible for a higher discount for MCP Papers");
        }
else
{
        Console.WriteLine("Try again");
        Console.WriteLine("See you Later........");

}
}
}
}