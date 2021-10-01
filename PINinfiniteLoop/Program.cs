using System;

namespace PINinfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //rogramm küsib kasutajal sisestada PIN-kood;
            //programm võrdleb sisestatud PIN-koodi arvuga 1234;
            //kui siestatud PIN-kood on 1234, siis konsool kuvab "Tere tulemast!";
            //kui sisestatud PIN-kood on midagi muud, siis konsool kuvab "Vale PIN. Proovi uuesti!";
            //katsete arv on piiramatu

            bool loopActive = true; //boolean --> true/false
            int i = 0;

            while (loopActive)
            {
                Console.WriteLine("Sisesta PIN:"); //cw double TAB
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    loopActive = false;

                }
                else
                {
                    i++;
                    Console.WriteLine(" Vale PIN. Proovi uuesti!");
                    Console.WriteLine($"Oled vale PIN kood {i} korda sisestanud");
                }

                
            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
