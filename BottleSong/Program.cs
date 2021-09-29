using System;

namespace BottleSong
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 99; i > 0; i--)
            {
                
                if (i > 2)
                {
                    Console.WriteLine($"{i} bottles of beer on the wall, {i} bottles of beer. ");
                    Console.WriteLine($"Take one down and pass it around, {i - 1} bottles of beer on the wall.");
                }
                else if (i == 2)
                {
                    Console.WriteLine($"{i} bottles of beer on the wall, {i} bottles of beer. ");
                    Console.WriteLine($"Take one down and pass it around, {i - 1} bottle of beer on the wall.");
                }
                else
                {
                    Console.WriteLine($"{i} bottle of beer on the wall, {i} bottle of beer. ");
                    Console.WriteLine("Take one down and pass it around, no more bottles of beer on the wall.");
                }
            }
            Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer.");
            Console.WriteLine("Go to the store and by some more, 99 bottles of beer on the wall.");
        }
    }
}
