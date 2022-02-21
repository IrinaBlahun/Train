using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N");
            int size = int.Parse(Console.ReadLine());
            for (int i = 1; i <= size; i++)
                Console.WriteLine(i % 3 == 0 ? "*" : i.ToString());

        }
    }
}
