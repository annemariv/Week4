using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri 1-10;
            //kui genereeritud nr on 5, programm lõpetab oma töö ja soovib kasutajale "Kena päeva";
            //kui genereeritud nr on midagi muud, programm jätkab tööd.

            Random rnd = new Random();
            int i = 0;

            while (i != 5)
            {
                int myRandomNumber = rnd.Next(1, 11);
                Console.WriteLine($"Juhuslik number on: {myRandomNumber}");
                if(myRandomNumber == 5)
                {
                    i = myRandomNumber;
                }
            }

            Console.WriteLine("Kena päeva!");

            //Console.WriteLine($"Juhuslik number on {myRandomNumber}");


        }
    }
}
