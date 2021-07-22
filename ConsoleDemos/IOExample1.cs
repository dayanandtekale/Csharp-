using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleDemos
{
    class IOExample1
    {
        public static void Main(string[] args)
        {
            string path = "C:\\pwc.txt";
            if (!File.Exists(path))
            { 
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s=sr.ReadLine()) !=null)
                    {
                        Console.WriteLine(s);
                    }
                }
                File.Delete(@"C:\hello.txt");
                Console.WriteLine("File deleted");
             }
        }
    }
}
