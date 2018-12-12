using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trim
{
    class Program
    {
        static void Main(string[] args)
        {
            string str, str1;
            char[] Trimchars = { '*', ' ', '\'' };
            Console.Write("Give me the first string:");
            str = Console.ReadLine();
            str1 = str.Trim(Trimchars);
            Console.Write("The result  is now:{0}", str1 );
            Console.ReadKey();

        }
    }
}
