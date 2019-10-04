using System;

namespace Tund6
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int cpuNumber;
            int tries = 0;
            bool gameOver = false;

            //Genereeri suvaline number 1-10ni.
            Random rnd = new Random();
            cpuNumber = rnd.Next(1, 11);

            Console.WriteLine("Palun sisesta oma nimi");
            name = Console.ReadLine();

            Console.WriteLine($"Tere {name}.");

            //!gameOver = Not gameOver = true
            while (!gameOver)
            {
                int userNumber;
                Console.WriteLine("Proovi ära arvata number 1-10ni.");
                userNumber = int.Parse(Console.ReadLine());

                if (userNumber > cpuNumber)
                {
                    Console.WriteLine("Sinu number on suurem kui minu oma, proovi uuesti.");

                }
                else if(userNumber < cpuNumber)
                {
                    Console.WriteLine("Sinu number on väiksem kui minu oma, proovi uuesti.");
                }
                else
                {
                    Console.WriteLine("Hehe, ära arvasid!");
                    gameOver = true;
                }

            }

            Console.ReadLine();








        }
    }
}
