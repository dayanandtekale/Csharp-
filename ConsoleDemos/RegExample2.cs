using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleDemos
{
    class RegExample2
    {
        public static void Main(string[] args)
        {
            Regex rg1 = new Regex(@"E\d{3}", RegexOptions.IgnoreCase);
            string empcode1 = "e001";
            string empcode2 = "E1";
            Match m1 = rg1.Match(empcode1);
            Match m2 = rg1.Match(empcode2);
            Console.WriteLine($"Match for{empcode1} is {m1.Success}");
            Console.WriteLine($"Match for{empcode1} is {m2.Success}");
        }
    }
}
