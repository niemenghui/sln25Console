using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca.i5i.c
{
    class Thread4
    {
        static void Main(string[] args)
        {
            SingleThread01();
            Console.Read();

            Multithread02();
            Console.Read();
        }
             
        static void Multithread02()
        {
            Console.WriteLine("Multithread app BEGIN");
            Console.WriteLine("Main Thread Started");
            //Creating Threads
            Thread t1 = new Thread(Method1);
            t1.IsBackground = true;  //makes the thread a background thread, and then starts the thread. Seems not a big deal.
            t1.Name = "t1Name";

            Thread t2 = new Thread(Method2)
            {
                Name = "Thread2"
            };

            Thread t3 = new Thread(Method3)
            {
                Name = "Thread3"
            };

            //Executing the methods
            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("Main Thread Ended");
            Console.WriteLine("Multithread app END");
        }        

        static void SingleThread01()
        {
            Console.WriteLine("single Thread app BEGIN");
            Method1();
            Method2();
            Method3();
            Console.WriteLine("single Thread app END");
        }

        static void Method1()
        {
            Random rnd = new Random();  // to get a random integer within a specified range..
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(rnd.Next(-1, 12) + "Method1 :" + i);
            }
        }

        static void Method2()
        {
            int intSleep = 10000;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method2 :" + i);
                if (i == 3)
                {
                    Console.WriteLine("Performing the Database Operation Started");
                    //Sleep for 10 seconds
                    Thread.Sleep(intSleep);
                    Console.WriteLine("Performing the Database Operation Completed in seconds:" + intSleep/1000);
                }
            }
        }
        static void Method3()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method3 :" + i);
            }
        }
    }
}
