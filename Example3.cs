using System;
namespace csharp
{
     public class Example3
     {
public static void Main(String[] args)
{

int a=12;
int b=7;
int c=9;
int d=30;
Console.WriteLine("Initial values:A={0}, B={1}, C={2}, D={3}", a, b,c, d);
a++;
b--;
c=d++;
b+=d;
a=--d;
d%=c;
c--;
d=--c;
a+=d;
c=d;

Console.WriteLine("Final values:A={0}, B={1}, C={2}, D={3}", a, b,c, d);

}
}
}