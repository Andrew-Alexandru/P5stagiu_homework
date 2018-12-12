using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            string str, str1;
            int result = 0;
            Console.Write("Give me the first string:");
            str = Console.ReadLine();
            Console.Write("Give me the second string:");
            str1 = Console.ReadLine();
            result = String.Compare(str, str1);
            Console.Write("The first string is now:{0}", result);
            Console.ReadKey();
        }
    }
}
