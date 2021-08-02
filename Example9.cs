using System;
namespace csharp
{
public class Example9
{
public static void Main(String[] args)
{

for(int ctr=0;ctr<=10;ctr++)
{          Console.WriteLine($"CTR= {ctr}");

}
int[] salary = new int[7];
salary[0]=500000;
salary[1]=1000000;
salary[2]=90000;
salary[3]=90000;
salary[4]=90000;
salary[5]=40000;
salary[6]=60000;

foreach(int x in salary)
Console.WriteLine($"The Salary is {x}");

}
}
}