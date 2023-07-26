using System;
namespace Sample
{
    delegate void Calculator(int a, int b);

    internal class Program
    {
        static void Plus(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void Minus(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void PrintResult(Calculator calcFunction, int a, int b)
        {
            calcFunction(a, b);
        }
        static void Main(string[] args)
        {
            PrintResult(Plus, 11, 7);
            PrintResult(Minus, 3, 24);
        }
    }
}