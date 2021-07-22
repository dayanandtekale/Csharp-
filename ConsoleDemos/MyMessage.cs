using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDemos
{
    class MyMessage
    {
        public string from;
        public string to;
        public void sendMsg()
        {
            Console.WriteLine($"{from} said Happy New Year to {to}");
        }
    }
    class WhatsAppMsg : MyMessage
    {
        public string MessageType;

        public void newsendMsg()
        {
            Console.WriteLine($"{MessageType} received by {base.to} from {base.from}");
        }
    }
}
