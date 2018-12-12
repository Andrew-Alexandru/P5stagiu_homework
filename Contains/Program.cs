using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contains
{
    class Program
    {
        static void Main(string[] args)
        {
            string str, str1;
            Console.Write("Give me the first string:");
            str = Console.ReadLine();
            Console.Write("Give me the second string:");
            str1 = Console.ReadLine();
            Console.Write("The result  is now:{0}", str.Contains(str1));
            Console.ReadKey();
        }
    }
}
