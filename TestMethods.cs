using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Multithreading
{
    public static class TestMethods
    {
       

        public static void Method1()
        {
            Console.WriteLine("start procedury 1");

            for (int i = 0; i < 100000; i++)
            {
                Console.WriteLine("procedura 1 " + i);
            }

            Console.WriteLine("koniec procedury 1");

        }
        public static void Method2()
        {
            Console.WriteLine("start procedury 2");

            for (int i = 0; i < 100000; i++)
            {
                Console.WriteLine("procedura 2 " + i);
            }

            Console.WriteLine("koniec procedury 2");

        }
        public static void Method3()
        {
            Console.WriteLine("start procedury 3");

            for (int i = 0; i < 100000; i++)
            {
                Console.WriteLine("procedura 3 " + i);
            }

            Console.WriteLine("koniec procedury 3");

        }


        public static void ConcurrentBagTestAdd(long count)
        {
            try
            {
                var bag = new ConcurrentBag<long>();
                Console.WriteLine($"--- ConcurrentBagTest liczba el. = {count}");
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                for (long i = 0; i < count; i++)
                {
                    bag.Add(i);
                }
                stopwatch.Stop();
                Console.WriteLine($"Dodano {bag.LongCount()} el. w {stopwatch.Elapsed.TotalSeconds} s");
                Console.WriteLine();
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        public static void ListTestAdd(long count)
        {
            try
            {
                var list = new List<long>();
                Console.WriteLine($"--- ListTest liczba el. = {count}");
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                for (long i = 0; i < count; i++)
                {
                    list.Add(i);
                }
                stopwatch.Stop();
                Console.WriteLine($"Dodano {list.LongCount()} el. w {stopwatch.Elapsed.TotalSeconds} s");
                Console.WriteLine();
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void ConcurrentBagTestAddRemove(long count)
        {
            try
            {
                var bag = new ConcurrentBag<long>();
                Console.WriteLine($"--- ConcurrentBagTest liczba el. = {count}");
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                for (long i = 0; i < count; i++)
                {
                    bag.Add(i);
                }
                for (int i = 0; i < count; i++)
                {
                    bag.TryTake(out _);
                }

                stopwatch.Stop();
                Console.WriteLine($"Dodano i usunięto {count} el. w {stopwatch.Elapsed.TotalSeconds} s");
                Console.WriteLine();
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        public static void ListTestAddRemove(long count)
        {
            try
            {
                var list = new List<long>();
                Console.WriteLine($"--- ListTest liczba el. = {count}");
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                for (long i = 0; i < count; i++)
                {
                    list.Add(i);
                }
                for (int i = 0; i < count; i++)
                {
                    list.RemoveAt(0);
                }
                stopwatch.Stop();
                Console.WriteLine($"Dodano i usunięto {count} el. w {stopwatch.Elapsed.TotalSeconds} s");
                Console.WriteLine();
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
