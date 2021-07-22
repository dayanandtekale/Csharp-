using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CSharpConsole
{
    class regexpexample
    {
        public static void Main(string[] args)
        {

            Regex rx = new Regex(@"lata", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            Regex rx1 = new Regex(@"\d{12}");
            string mobilenumber = "781117858962";

            string str = "LATA";
            MatchCollection matches = rx.Matches(str);
            Console.WriteLine(matches.Count.ToString());

            Match datamatch2 = rx1.Match(mobilenumber);
            Console.WriteLine($"{datamatch2.Success}, The data is {datamatch2.Value}");

        }
    }
}
