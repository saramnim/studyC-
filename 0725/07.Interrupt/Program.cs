using System;

namespace Sample
{
    internal class Program
    {
        static void DoSomething()
        {
            for(int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"DoSomething:{i}");
                Thread.Sleep(10);
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(DoSomething));
            t1.Start();
            t1.Interrupt();
            t1.Join();
        }
    }
}