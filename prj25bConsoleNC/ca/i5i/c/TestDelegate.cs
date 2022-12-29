using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int NumberChanger(int n);

namespace ca.i5i.c
{
    class TestDelegate
    {
        // define a method that returns sum of two int numbers.
        static int calculateSum(int x, int y)
        {
            return x + y;
        }

        // define a delegate.
        public delegate int myDelegate(int num1, int num2);   
       
        static void Main()
        {
            // create an instance of delegate by passing method name. 
            myDelegate d = new myDelegate(calculateSum);  //  create an instance of myDelegate d and passed calculateSum() as a parameter.

            // calling calculateSum() using delegate. Either invoking with Invoke:         
            //int result = d.Invoke(5, 6);
            int result = d(5, 6);   // or invoking without Invoke.
            Console.WriteLine(result);
        }
    }
}
