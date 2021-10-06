using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis on ta mängu võitnud;
            //katsete arv on piiramatu;
            //*programm genereerib juhuslikku numbrit ühe korra;

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            Console.WriteLine("Arva number 1-10-ni.");

            while (true)
            {
                int userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber != cpuNumber)
                {
                    Console.WriteLine("Vale number! Proovi uuesti!");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Õige number! Võitsid mängu!");
            
        }
    }
}