using System;
namespace csharp
{
public class Example7
{
public static void Main(String[] args)
{
string country;
Console.WriteLine("Enter the country name");
country= (Console.ReadLine()).ToUpper();
       switch (country)
       {
            case "INDIA":
                System.Console.WriteLine("Namaste");
                break;
            case "SPAIN":
                System.Console.WriteLine("Hola");
                break;
             case "FRANCE":
                System.Console.WriteLine("Bonjour");
                break;
       default:
                System.Console.WriteLine("Hi");
                break;
           }}}}

