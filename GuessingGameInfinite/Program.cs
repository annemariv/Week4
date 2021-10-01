using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri 1-10;
            //kasutaja peab seda nr ära arvama;
            //kui kasutaja suutis selle nr ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu
            //programm genereerib juhusliku nr vaid 1 kord.


            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            
       
            bool loopActive = true; 
            int i = 0;

            Console.WriteLine("Sisesta number:");

            while (loopActive)
            {
                int myRandomNumber = rnd.Next(1, 11);
                int userPIN = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Juhuslik number on: {myRandomNumber}");
                if (userPIN == myRandomNumber)
                {
                    Console.WriteLine("Oled võitnud!");
                    i = myRandomNumber;
                    loopActive = false;
                }
                else
                {
                    i++;
                    Console.WriteLine("Arvuti võitis.");
                }
            }



        }

        }
    }
