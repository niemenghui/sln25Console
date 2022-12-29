using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca.i5i.c
{
    public delegate void MyDelegate(string msg);
    public class Delegate2
    {
        public static void Main()
        {
            MyDelegate del = ClassA.MethodA;
            del("Hello WorldA");

            del = ClassB.MethodB;
            del("Hello WorldB");

            del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
            del("Hello WorldL");
        }
    }

    public class ClassA
    {
        public static void MethodA(string message)
        {
            Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
        }
    }

    public class ClassB
    {
        public static void MethodB(string message)
        {
            Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
        }
    }
}
