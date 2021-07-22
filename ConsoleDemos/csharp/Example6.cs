using System;
namespace csharp
{
public class Example6
{
public static void Main(String[] args)
{
int income; 
float tax;
tax=0.0f;
Console.WriteLine("Enter your income");
income= System.Convert.ToInt32(Console.ReadLine());
if(income>1000000)
      tax= 0.2f *(income-100000)+500000*0.1f+ 250000*0.05f;
else
      if(income>500000)
           tax= 0.1f *(income-50000)+ 250000*0.05f;

      else
          if(income> 250000)
              tax= 0.05f *(income-250000);
          else
              tax=0*income;
System.Console.WriteLine("The tax for income {0} is {1}", income,tax);
}
}
}