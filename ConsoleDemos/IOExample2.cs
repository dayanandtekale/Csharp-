using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
  using ConsoleDemos;

namespace ConsoleDemos
{
    class IOExample2
    {
        public static void Main()
        {
            FileStream fs = new FileStream(@"C:\emp.txt", FileMode.Create, FileAccess.Write);

            emp obj = new emp();
            obj.empid = 10;
            obj.empname = "abc";

            BinaryFormatter bformatter = new BinaryFormatter();
            bformatter.Serialize(fs, obj);

            fs.Close();
            Console.WriteLine("Data Written to the file");
            Console.WriteLine("**********************************")
                FileStream fs1 = new FileStream(@"C:\emp.txt", FileMode.Open, FileAccess.Read);
            emp obj1 = new emp();

            BinaryFormatter bformatter1 = new BinaryFormatter();
            obj1 = (emp)beformatter1.Deserilize(fs1);
            fs1.Close();
            Console.WriteLine(obj1.empid);
            Console.WriteLine(obj1.empname);

        }
    }
}
