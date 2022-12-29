using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca.i5i.c
{
    public delegate int MyDelegate4();
    public class MulticastDelegateReturn4
    {
        public static void Main()
        {
            MyDelegate4 del1 = ClassE.MethodE;
            MyDelegate4 del2 = ClassF.MethodF;

            MyDelegate4 del = del1 + del2; 
            //If a delegate returns a value, then the last assigned target method's value will be return when a multicast delegate called.

            Console.WriteLine(del());  // will return 200.
        }
    }

    public class ClassE
    {
        public static int MethodE()
        {
            Console.WriteLine("in MethodE");
            return 100;
        }
    }

    public class ClassF
    {
        public static int MethodF()
        {
            Console.WriteLine("in MethodF");
            return 200;
        }
    }
}
