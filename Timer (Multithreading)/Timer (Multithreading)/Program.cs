using System;
using System.Threading;

namespace Timer__Multithreading_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a timer that count down and up simultaneously - made using C# multithreading");
            Console.WriteLine();

            Thread thread1 = new Thread(() => CountDown("Timer #1"));
            Thread thread2 = new Thread(() => CountUp("Timer #2"));

            thread1.Start();
            thread2.Start();

            Console.ReadKey();
        }

        public static void CountDown(String name)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer #1 : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 is complete!");
        }
        public static void CountUp(String name)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer #2 : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 is complete!");
        }
    }
}
