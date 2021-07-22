using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDemos
{
    class Demo2
    {
        static void Main(string[] args)
        {
            MyMessage obj = new MyMessage();
            obj.from = "Lata";
            obj.to = "Aditya";
            obj.sendMsg();
            WhatsAppMsg Objw = new WhatsAppMsg();
            Objw.from = "12121213";
            Objw.to = "1313";
            Objw.MessageType = "Audio";

            Objw.sendMsg();
        }
    }
}
