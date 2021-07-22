using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDemos
{
    class Demo1
    {
        static void Main(string[] args)
        {
            product obj = new product();
            obj.display();
        }
        
                  
    }
        class product
        {
            int price = 40;
            string productname="Sanitizer";
            public void display()
            {
                Console.WriteLine($"The price of the {productname} is {price}");
            }
        }
    
}
