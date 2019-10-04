using System;

namespace Tund6_teine_äpp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere tulemast!");
            Console.WriteLine("Palun sisesta oma nimi");
            string name;
            name = Console.ReadLine();
            Console.WriteLine($"Tere {name}.");

            start:
            int cpuNumber;
            int tries = 0;
            bool gameOver = false;

            //Genereeri suvaline number 1-10ni.
            Random rnd = new Random();
            cpuNumber = rnd.Next(1, 11);

           

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
                else if (userNumber < cpuNumber)
                {
                    Console.WriteLine("Sinu number on väiksem kui minu oma, proovi uuesti.");
                }
                else
                {
                    Console.WriteLine("Hehe, ära arvasid! Tahad uuesti mängida? Jah/Ei?");
                    string userAnswer = Console.ReadLine();

                    //ToUpper() vs. ToLower()
                    if(userAnswer.ToLower() == "jah")
                    {
                        goto start;
                    }
                    else
                    {
                        Console.WriteLine("Mäng läbi!");
                        gameOver = true;
                    }



                }

            }

            Console.ReadLine();

        }
    }
}
