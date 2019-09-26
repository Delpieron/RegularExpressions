using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions
{
    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                string text = Console.ReadLine();
                bool isOK = Regex.IsMatch(text, "^([[:alnum:]])*([0-9.])*[[:alnum:]]*+@([[:alnum:]])*+[0-9.]{1}([[:alnum:]])*");
                Console.WriteLine(isOK);
                Console.Read();
            }
        }
    }
}
