//#define DEBUG
//#define TRACE   // this is never needed, c_TRACE always print;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca.i5i.c
{
    public class Myclass
    {
        [Conditional("TRACE")]      //  always print.
        //[Conditional("DEBUG")]    //  only #DEBUG will print.
        public static void Message(string msg)
        {
            Console.WriteLine(msg);
        }


        //[Obsolete("Please use NewMethod instead", true)]
        [Obsolete("Please use NewMethod instead")]  //  iserror is FALSE by default(compiler generates a warning).
        public static void OldMethod()
        {
            Console.WriteLine("It is the old method");
        }

    }
    class Test
    {
        static void function1()
        {
            Myclass.Message("In Function 1.");
            function2();
        }
        static void function2()
        {
            Myclass.Message("In Function 2.");
        }
        public static void Main()
        {
            Myclass.Message("In Main function.");
            function1();
            Myclass.OldMethod();

            Console.ReadKey();
        }
    }
}
