using System;

namespace SampleCode
{
    delegate void EventHandler(string message);
    class myNotifier
    {
        public event EventHandler SomethingHappened;
        public void DoSomething(int number)
        {
            int temp = number % 3;
            if (temp == 0)
            {
                SomethingHappened($"number = {number}");
            }
        }
    }
    internal class Program
    {
        static public void MyHandler(string message)
        {
            Console.WriteLine(message);
        }
        static void Maini(string[] args)
        {
            myNotifier notifier = new myNotifier();
            notifier.SomethingHappened += new EventHandler(MyHandler);

            for (int i = 1; i < 30; i++)
            {
                notifier.DoSomething(i);
            }
        }
    }
}
