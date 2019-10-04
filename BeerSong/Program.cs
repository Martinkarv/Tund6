using System;

namespace BeerSong
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 99; i > 2; i--)
            {

                Console.WriteLine($"{i} bottles of beer on the wall, {i} bottles of beer.");
                Console.WriteLine($"Take one down and pass it around, {i - 1} bottles of beer on the wall.");


            }

            Console.WriteLine("2 bottles of beer on the wall, 2 bottles of beer."
                + "Take one down and pass it around, 1 bottle of beer on the wall.");

            Console.WriteLine("1 bottle of beer on the wall, 1 bottle of beer."
                + "Take one down and pass it around, no more bottles of beer on the wall.");

                Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer." +
                    "Go to the store and buy some more, 99 bottles of beer on the wall.");
           
            Console.ReadLine();
        }
    }
}
