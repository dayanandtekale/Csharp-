using System;
namespace csharp
{
public class Example8
{
public static void Main(String[] args)
{

Console.WriteLine("While Loop");
int ctr=1;
while(ctr<=10)
         {
          Console.WriteLine($"The value of Ctr is {ctr}");
          ctr++;
         }
Console.WriteLine("Do While Loop Example");
ctr=1;
do       {
          Console.WriteLine($"The value of Ctr is {ctr}");
          ctr+=2;
         }
while(ctr<=10);
}
}
}