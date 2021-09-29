using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a word to reverse");
            string id = Console.ReadLine();
            for (int i = id.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(id[i]);
            }
        }
    }
}
