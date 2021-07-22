using System;
namespace csharp
{
public class Example4
{
public static void Main(String[] args)
{
string ApplicantName;
int Score;
Console.WriteLine("Enter the Applicant Name");
ApplicantName=Console.ReadLine();
Console.WriteLine("Enter the Score");
Score= System.Convert.ToInt32(Console.ReadLine());
     if(Score>=80)
     Console.WriteLine("Accepted");
     else
         Console.WriteLine("Rejected");
         Console.WriteLine("***********************Syntax2*********************");

     if(Score>=90)
     {
     Console.WriteLine("Accepted");
     Console.WriteLine("An offer Letter will be sent to you instantly");
     }
}
}
}