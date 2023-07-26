using System;

namespace Sample
{
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] arr = { 1, 2, 3 };
    //        try
    //        {
    //            for (int i = 0; i < 5; i++)
    //            {
    //                Console.WriteLine("{0}", arr[i]);
    //            }
    //        }
    //        catch(System.Exception e)
    //        {
    //            Console.WriteLine("예외 발생: {0}", e.Message);
    //        }
    //    }
    //}
    internal class Program
    {
        static void DoSomething(int arg)
        {
            if (arg < 10)
            {
                Console.WriteLine($"arg: {arg}");
            }
            else throw new Exception("arg가 10보다 크다");
        }
        static void Main(string[] args)
        {
            try
            {
                DoSomething(11);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}