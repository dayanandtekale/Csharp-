using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSharpConsole
{
    class Demo5
    {
        public static void Main(string[] args)
        {
            Queue myQ = new Queue();
            myQ.Enqueue("Manisha");
            myQ.Enqueue("12");
            myQ.Enqueue("Mitesh");
            System.Console.WriteLine("***********Original Queue*********");
            System.Console.WriteLine("The number of elements in the queue are" + myQ.Count);



            foreach (string x in myQ)
                Console.WriteLine(x);
            myQ.Dequeue();
            System.Console.WriteLine("***********Final Queue*********");



            foreach (string x in myQ)
                Console.WriteLine(x);



        }
    }
}