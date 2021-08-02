using System;
namespace CsharpFinal
{
    public class encapsulation
    {
        public static void Main(string[] args)
        {
            customer obj = new customer();
            obj.custname = "ABC";
            obj.pincode = "411003";
            System.Console.WriteLine($"CustomerName={obj.custname} and Pincode={obj.pincode}");
            obj.displaycity();
        }
    }
    public class customer
    {
        internal string custname;
        internal string pincode;
        private string city;
        public void displaycity()
        {
            if (pincode == "400066")
                city = "Mumbai";
            if (pincode == "411003")
                city = "Pune";
        }
    }
}