using System;
namespace sample
{
    class Car
    {
        private static int count;
        private string name;
        public Car(string name)
        {
            this.name = name;
            count++;
        }
        public static void PrintCount()
        {
            Console.WriteLine("Number of cars: {0}", count);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car.PrintCount();
            Car car1 = new Car("K3");
            Car car2 = new Car("Avante");
            Car car3 = new Car("Model 2");

            Car.PrintCount();

            Console.ReadLine();
        }
    }
}