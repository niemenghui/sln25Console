using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca.i5i.c
{
    public delegate T add<T>(T param1, T param2);
    public class GenericDelegate5
    {
        public static void Main()
        {
            add<int> sum = Sum;
            Console.WriteLine(sum(10, 20));

            add<string> conct = Concat;
            Console.WriteLine(conct("Hello", "World!!"));
        }

        public static int Sum(int val1, int val2)
        {
            return val1 + val2;
        }

        public static string Concat(string str1, string str2)
        {
            return str1 + str2;
        }
    }
}
