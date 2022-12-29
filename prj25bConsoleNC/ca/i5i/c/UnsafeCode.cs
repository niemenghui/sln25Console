using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca.i5i.c
{
    class UnsafeCode
    {
        //static void Main(string[] args)
        static unsafe void Main(string[] args)
        {
            int var = 20;
            int* p = &var;
            Console.WriteLine("Data is: {0} ", var);
            Console.WriteLine("Address is: {0}", (int)p);

            fixed1();
            Method2();
       
            int var1 = 10;
            int var2 = 20;
            int* x = &var1;
            int* y = &var2;
            Console.WriteLine("Before Swap: var1:{0}, var2: {1}", var1, var2);
            swap3(x, y);
            Console.WriteLine("After Swap: var1:{0}, var2: {1}", var1, var2);
        }

        public unsafe static void fixed1()
        {
            int[] list = { 10, 100, 200 };
            fixed (int* ptr = list)
                /* let us have array address in pointer */
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Address of list[{0}]={1}", i, (int)(ptr + i));
                    Console.WriteLine("Value of list[{0}]={1}", i, *(ptr + i));
                }
        }

        public unsafe static void Method2()
        {
            int x = 10;
            int y = 20;
            int* ptr1 = &x;
            int* ptr2 = &y;
            Console.WriteLine((int)ptr1);  // print memory address.
            Console.WriteLine((int)ptr2);
            Console.WriteLine(*ptr1);
            Console.WriteLine(*ptr2);
        }

        public unsafe static void swap3(int* p, int* q)
        {
            int temp = *p;
            *p = *q;
            *q = temp;
        }
    }
}
