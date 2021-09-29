using System;

namespace UserNumberSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please enter a number.");
                numb = numb + Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The sum of those numbers is {numb}");
        }
    }
}
