using System;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter("test.txt"))
            {
                writer.WriteLine("Hello, world");
                writer.WriteLine("안녕하세요");
            }
            using (StreamReader reader = new StreamReader("test.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}