using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleDemos
{
    class Demo4
    {
        public static void Main(string[] args)
        {
            Queue myQ = new Queue();
            myQ.Enqueue("Maggi");
            myQ.Enqueue("12");
            myQ.Enqueue("Master");
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
