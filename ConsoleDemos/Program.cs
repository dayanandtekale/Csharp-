

using System;
using ConsoleDemos;



namespace ConsoleDemos{
    class Program
    {
        static void Main(string[] args)
        {
            float ans;
            Customer obj = new Customer();
            obj.CustomerName = "ABC";
            obj.CustomerCity = "Surat";
            Console.WriteLine($"I am {obj.CustomerName} from {obj.CustomerCity}");
            obj.CustomerCare();
            ans = obj.AvailDiscount(7000f);
            Console.WriteLine($"The final amount payable is {(7000 - ans)}");




        }
    }



}
