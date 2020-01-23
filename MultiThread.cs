using System;
using System.Diagnostics;
using System.Threading;

namespace Multithreading
{
    public class MultiThread
    {
        public MultiThread()
        {
        }


        public static void Main(string[] args)
        {

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            Thread t1 = new Thread(TestMethods.Method1);
            Thread t2 = new Thread(TestMethods.Method2);
            Thread t3 = new Thread(TestMethods.Method3);

            t1.Start();
            t1.Join();

            t2.Start();
            t2.Join();

            t3.Start();
            t3.Join();

            stopwatch.Stop();


            Console.WriteLine("czas wykonania na wielu watkach " + stopwatch.ElapsedMilliseconds);
            Console.WriteLine("koniec watku glownego");
            Console.ReadKey();

        }


    }
}

