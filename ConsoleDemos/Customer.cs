using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleDemos
{
    class Customer
    {
        public string CustomerName;
        public string CustomerCity;
        public void CustomerCare()
        {
            Console.WriteLine("It is Lockdown and I have limited time to SHOP");
        }
        public float AvailDiscount(float amt)
        {
            float finalAmount;
            float disc = 0.2f;
            if (amt > 5000)
                disc = 0.4f;
            finalAmount = disc * amt;
            return finalAmount;
        }
    }
}

