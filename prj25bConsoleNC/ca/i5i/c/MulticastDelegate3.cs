using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca.i5i.c
{
    public delegate void MyDelegate3(string msg);
    public class MulticastDelegate3
    {
        public static void Main()
        {
            MyDelegate3 del1 = ClassC.MethodC;
            MyDelegate3 del2 = ClassD.MethodD;

            MyDelegate3 del = del1 + del2;
            Console.WriteLine("After del1 + del2");
            del("Hello +World");

            MyDelegate3 del3 = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
            del += del3;
            Console.WriteLine("After del1 + del2 + del3");
            del("Hello ++World");

            del = del - del2;
            Console.WriteLine("After del - del2");
            del("Hello -World");

            del -= del1;
            Console.WriteLine("After del - del1");
            del("Hello -- World");
        }
    }

    public class ClassC
    {
        public static void MethodC(string message)
        {
            Console.WriteLine("Called ClassC.MethodC() with parameter: " + message);
        }
    }

    public class ClassD
    {
        public static void MethodD(string message)
        {
            Console.WriteLine("Called ClassD.MethodD() with parameter: " + message);
        }
    }
}
