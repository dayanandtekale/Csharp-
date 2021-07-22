using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDemos
{
    class Mobile1
    {
        private
            int mobilenumber;
        string operatingsystem

        public void acceptdata()
        {
            Console.WriteLine("Enter Your Mobile Number:-");
            mobilenumber = Console.ReadLine();
            Console.WriteLine("Enter the Operating System:-");
            operatingsystem = Console.ReadLine();
        }
        public void displaydata()
        {
            Console.WriteLine("Mobile Number===>" + mobilenumber);
            Console.WriteLine("Operating Systemr===>" + operatingsystem);
        }

    }
    class Mobile2
        {
        static void Main(String[] args)
        {
         mobile1 obj = mobile2();
         obj.acceptData();
         obj.displayData();

        Console.ReadLine();

        }
     }
}
