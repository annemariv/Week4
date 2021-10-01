using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri 1-10;
            //kasutaja peab seda nr ära arvama;
            //kui kasutaja suutis selle nr ära arvata, siis ta on mängu võitnud;
            //katsete arv on 3, kui kasutaja ei suuda ära arvata 3 katsega, siis mängu võidab arvuti;
            //programm genereerib juhusliku nr vaid 1 kord.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            Console.WriteLine("Sisesta number:");
           

            int i = 0;

            while (i < 3)
            {
                int myRandomNumber = rnd.Next(1, 11);
                int userPIN = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Juhuslik number on: {myRandomNumber}");

                if (userPIN == myRandomNumber)
                {
                    Console.WriteLine("Oled võitnud!");
                    i = myRandomNumber;
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale number. {3 - i} katset on jäänud.");
                    Console.WriteLine("Arvuti võitis.");
                }
            }
           
             


                }
            }
    }