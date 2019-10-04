using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
           // int number= 0;
            //int i = 0 - start of the loop, i < 10 -stop; i++ -step

            for(int i = 1; i < 11; i++)
            {
                Console.WriteLine($"i on {i}");
            }
            Console.WriteLine();

            for (int i = 10; i > -1; i--)
            {
                Console.WriteLine($"i on {i}");
            }
            Console.ReadLine();
        }
    }
}
