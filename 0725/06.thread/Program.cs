using System;

namespace Sample
{
    internal class Program
    {
        static void DoSomething()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"DoSomething: {i}");
            }
        }
        static void Main(string[] args) 
        {
            Thread t1 = new Thread(new ThreadStart(DoSomething));
            t1.Start();
            t1.Join();
        }
    }
}