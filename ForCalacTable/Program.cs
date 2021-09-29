using System;

namespace ForCalacTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to see the multiplication table of that number");
            int num = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < 101; i++)
            {
                Console.WriteLine($"{i} * {num} = {i * num}");
            }
        }
    }
}
